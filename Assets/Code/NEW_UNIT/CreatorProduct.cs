using Assets.Code.Static_Class;
using System.Collections;
using UnityEngine;

namespace Assets.Code.NEW_UNIT
{
    public static class CreatorProduct
    {
        public static void Unit(int CountAddUnit)
        {
            for (int i = 0; i < CountAddUnit; i++)
            {
                NewUnit CurrentPlayer = UnitPool.instanсe.UnitComponent;
                MainStaticClass.TransferPoint(CurrentPlayer.transform, AllData.instanse.PlayerCommand.transform, true);

                CurrentPlayer.Inizialization();
                AllData.instanse.CurrentUnitGamePlay.Add(CurrentPlayer);
            }
        }
    }
}