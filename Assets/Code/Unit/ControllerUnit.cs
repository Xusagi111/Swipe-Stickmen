using System;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Code.Unit
{
    public class ControllerUnit : MonoBehaviour
    {
        public static Action<int> PlayerUpdateUi;
       [SerializeField] private List<Unit> Unit = new List<Unit>();
        public List<Unit> CurrentUnitPlayer
        {
            get {

                if (Unit != null)
                    PlayerUpdateUi?.Invoke(Unit.Count +1);

                return Unit;
            }
            set {

                if (Unit != null)
                    PlayerUpdateUi?.Invoke(Unit.Count + 1);
              
                Unit =  value; 
            }
        }
    }
}