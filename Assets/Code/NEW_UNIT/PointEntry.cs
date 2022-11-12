using Assets.Code.StateGame;
using Assets.Code.Static_Class;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.NEW_UNIT
{
    public class PointEntry : MonoBehaviour
    {
        [SerializeField] private int _StartCountUnit = 30;
        [SerializeField] private ControllerMovePlayer _controllerUnit;
        [SerializeField] private TermsWin _termsWin;

        private void Start()
        {
            CreateUnit();
        }

        private void CreateUnit()
        {
            List<NewUnit> CurrentCreateUnit  = new List<NewUnit>(_StartCountUnit);

            for (int i = 0; i < _StartCountUnit; i++)
            {
                NewUnit CurrentPlayer = UnitPool.instanсe.UnitComponent;
                MainStaticClass.TransferPoint(CurrentPlayer.transform, AllData.instanse.PlayerCommand.transform, true);

                CurrentPlayer.Inizialization();
                CurrentCreateUnit.Add(CurrentPlayer);
            }

            CurrentCreateUnit[0].transform.position  += Vector3.one;

            AllData.instanse.CurrentUnitGamePlay = CurrentCreateUnit;
            _controllerUnit.AllCurrentUnitToPlayerCommand = CurrentCreateUnit;
        }
    }
}