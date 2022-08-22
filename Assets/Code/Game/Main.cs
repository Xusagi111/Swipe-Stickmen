using Assets.Code;
using Assets.Code.Static_Class;
using Assets.Code.Unit;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private int StartCountUnit;
    [SerializeField] private ControllerUnit controllerUnit;
    private CreatePointToUnit StartPlayerUnit; //Ограничить.

    private void Start()
    {
        StartPlayerUnit = new CreatePointToUnit();
        StartPlayerUnit.CreatePointPlayer();
        CreateUnit();

    }

    private void CreateUnit()
    {
        for (int i = 0; i < StartCountUnit; i++)
        {
            Unit CurrentPlayer = UnitPool.instanse.UnitComponent;
            MainStaticClass.TransferPoint(CurrentPlayer.transform, AllData.instanse.PlayerCommand.transform, true, StartPlayerUnit.layouteTransfetPoint[i]);
            controllerUnit.CurrentUnitPlayer.Add(CurrentPlayer);
        }
    }
}
