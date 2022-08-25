using Assets.Code._3d_My_Layoute;
using System.Collections.Generic;
using UnityEngine;
using static Assets.Code.MapToTrigger;

public struct DistansePoint
{
    public Transform TargetTransform;
    public float Distanse;
    public int SellPoint;
}
//1) Сделать быстрое обращение к элементам. 2) Разбросать по методам для более лучшей читаемости.
namespace Assets.Code.Unit
{
    public class Unit : MonoBehaviour, IUnit
    {
        [field: SerializeField] public CommandUnit commandUnit { get; set; }
        [field: SerializeField] public float countHp { get; set; }
        [HideInInspector] public Transform UnitPosition { get; set; }
        [HideInInspector] public Material MaterialUnit { get; set; }

        private void Awake()
        {
            UnitPosition = this.transform;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out MapToTrigger mapToTrigger)) { 
            
                if (mapToTrigger.TriggerCollision == TriggerPoint.Solid) { 
                
                    for (int i = 0; i < MainLayoute.instanse.list?[0].PlayerUnit?.Length; i++) { 

                        if (MainLayoute.instanse.list[0].PlayerUnit?[i]?[0] != null && MainLayoute.instanse.list[0].PlayerUnit?[i][0].gameObject.name == this.name)
                        {
                            MainLayoute.instanse.list[0].PlayerUnit[i][0] = null;
                            Debug.Log("Null Element  " + this.name );
                            return;
                        }
                    }
                }
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out MapToTrigger mapToTrigger))
            {
                if (mapToTrigger.TriggerCollision == TriggerPoint.Solid)
                {
                    for (int i = 0; i < MainLayoute.instanse.list?[0].PlayerUnit?.Length; i++)
                    {
                        if (MainLayoute.instanse.list[0].PlayerUnit?[i]?[0] != null && MainLayoute.instanse.list[0].PlayerUnit?[i][0].gameObject.name == this.name)
                        {
                            return;
                        }
                    }
                    var AllDistansePoint = new List<DistansePoint>();

                    //Сортировка по дистанции.
                    for (int i = 0; i < MainLayoute.instanse.list[0].PlayerUnit?[i].Length; i++)
                    {
                        var CurrentDistansePoint = Vector3.Distance(this.transform.position, MainLayoute.instanse.list[0].PlayerUnit[i][1].position);
                        var DataDistanse = new DistansePoint { Distanse = CurrentDistansePoint, SellPoint = i, TargetTransform = MainLayoute.instanse.list[0].PlayerUnit[i][1] };
                        AllDistansePoint.Add(DataDistanse);
                    }
                    AllDistansePoint.Sort((a, b) => a.Distanse.CompareTo(b.Distanse));

                    MainLayoute.instanse.list[0].PlayerUnit[AllDistansePoint[0].SellPoint][0] = this.UnitPosition;
                    return;
                }
            }

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Let")
            {
                for (int i = 0; i < MainLayoute.instanse.list?[0].PlayerUnit?.Length; i++)
                {
                    if (MainLayoute.instanse.list[0].PlayerUnit?[i]?[0] != null && MainLayoute.instanse.list[0].PlayerUnit?[i][0].gameObject.name == this.name)
                    {
                        MainLayoute.instanse.list[0].PlayerUnit[i][0] = null;
                       
                    }
                }
                ControllerUnit.instanse.CurrentUnitPlayer.Remove(this);
                ControllerUnit.PlayerUpdateUi?.Invoke(ControllerUnit.instanse.CurrentUnitPlayer.Count);
               
                UnitPool.instanse.UnitComponent = this;
            }
        }
    }
}
