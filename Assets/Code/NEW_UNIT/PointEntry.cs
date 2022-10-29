using Assets.Code.Static_Class;
using Assets.Code.Unit;
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
            for (int i = 0; i < StartCountUnit; i++)
            {
                NewUnit CurrentPlayer = UnitPool.instanse.UnitComponent;
                MainStaticClass.TransferPoint(CurrentPlayer.transform, AllData.instanse.PlayerCommand.transform, true);

                controllerUnit.AllCurrentUnitToPlayerCommand.Add(CurrentPlayer);
            }
            controllerUnit.AllCurrentUnitToPlayerCommand[0].transform.position  += Vector3.one;
        }
    }
}