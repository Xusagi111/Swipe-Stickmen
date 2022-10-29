using Assets.Code.Static_Class;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.NEW_UNIT
{
    public class PointEntry : MonoBehaviour
    {
        [SerializeField] private int StartCountUnit;
        [SerializeField] private ControllerMovePlayer controllerUnit;

        private void Start()
        {
            CreateUnit();
        }

        private void CreateUnit()
        {
            List<NewUnit> CurrentCreateUnit  = new List<NewUnit>(StartCountUnit);

            for (int i = 0; i < StartCountUnit; i++)
            {
                NewUnit CurrentPlayer = UnitPool.instanse.UnitComponent;
                MainStaticClass.TransferPoint(CurrentPlayer.transform, AllData.instanse.PlayerCommand.transform, true);

                CurrentPlayer.Inizialization();
                CurrentCreateUnit.Add(CurrentPlayer);
            }

            CurrentCreateUnit[0].transform.position  += Vector3.one;

            AllData.instanse.CurrentUnitGamePlay = CurrentCreateUnit;
            controllerUnit.AllCurrentUnitToPlayerCommand = CurrentCreateUnit;
        }
    }
}