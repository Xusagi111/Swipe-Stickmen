using System;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Code.Unit
{
    public class ControllerUnit : MonoBehaviour
    {
        public static ControllerUnit instanse;
        public static Action<int> PlayerUpdateUi;
        [SerializeField] private List<Unit> Unit = new List<Unit>();
        private const byte COUNT_PLAYER = 1;
        private void Start()
        {
            if (instanse != null) Destroy(instanse);
            instanse = this;
        }
        public List<Unit> CurrentUnitPlayer
        {
            get {

                if (Unit != null)
                    PlayerUpdateUi?.Invoke(Unit.Count + COUNT_PLAYER);

                return Unit;
            }
            set {

                if (Unit != null)
                    PlayerUpdateUi?.Invoke(Unit.Count + COUNT_PLAYER);
              
                Unit =  value; 
            }
        }
    }
}