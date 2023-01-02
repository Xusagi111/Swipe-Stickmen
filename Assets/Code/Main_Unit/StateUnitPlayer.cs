using Assets.Code.Level;
using Assets.Code.NEW_UNIT;
using UnityEngine;

namespace Assets.Code.Main_Unit
{
    public class StateUnitPlayer : MonoBehaviour
    {
        public static StateUnitPlayer instance { get; set; }

        private void Awake()
        {
            if (instance != null) Destroy(instance);
            instance = this;
        }
        
        public void HandlerFactorX(FactorXEn FactorX, int CountValueUnit)
        {
            switch (FactorX)
            {
                case FactorXEn.Plus:
                    AddedUnitToGamePlay(CountValueUnit);
                    break;
                case FactorXEn.Minus:
                    RemoveUnitPlayer(CountValueUnit);
                    break;
                case FactorXEn.Multiplication:
                    break;
            }
        }

        private void AddedUnitToGamePlay(int CountUnit)
        {
            CreatorProduct.Unit(CountUnit);
        }

        private void RemoveUnitPlayer(int CountUnit)
        {
            var a = AllData.instanse.CurrentUnitGamePlay;

            if (CountUnit >= a.Count)
            {
                foreach (var item in a)
                {
                    UnitPool.instanсe.UnitComponent = item;
                }
                AllData.instanse.CurrentUnitGamePlay.Clear();

            }
            else if (CountUnit < a.Count)
            {
                for (int i = 0; i < CountUnit; i++)
                {
                    UnitPool.instanсe.UnitComponent = a[i];
                }
                AllData.instanse.CurrentUnitGamePlay.RemoveRange(0, CountUnit);
            }
        }
    }
}