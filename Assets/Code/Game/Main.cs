using Assets.Code;
using Assets.Code.Static_Class;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private int StartCountUnit;
    private void Start()
    {
        CreeatePlayer();
    }
    private void CreeatePlayer()
    {
       
        for (int i = 0; i < StartCountUnit; i++)
        {
            Unit CurrentPlayer = UnitPool.instanse.UnitComponent;

            MainStaticClass.TransferPoint(CurrentPlayer.transform, AllData.instanse.PlayerCommand.transform,true);
        }
      
        //MainStaticClass.CreateUnit();
    }
}
