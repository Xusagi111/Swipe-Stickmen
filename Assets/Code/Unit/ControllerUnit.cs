using System;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Code.Unit
{
    public class ControllerUnit : MonoBehaviour
    {
        public static Action<int> PlayerUpdateUi;
       [SerializeField] private List<Unit> Unit = new List<Unit>();
        private const byte COUNT_PLAYER = 1;
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

        public CreatePointToUnit LayoutUnit;
        public int TargetPoint;
        public int TansferPointIdUnit;
        public Vector3 CurrentPositionunit;
        [ContextMenu("TestMove")]
        public void TestMoveUnit()
        {
            CurrentPositionunit = Unit[TansferPointIdUnit].gameObject.transform.position;
            Unit[TansferPointIdUnit].gameObject.transform.position = LayoutUnit.layouteTransfetPoint[TargetPoint].transform.position;
            var a = new Transform[2] { Unit[TansferPointIdUnit].UnitPosition, LayoutUnit.layouteTransfetPoint[TargetPoint].transform };
            LayoutUnit.PlayerUnit[TansferPointIdUnit] = a; 
        }
        [ContextMenu("ResetMove")]
        public void Reset()
        {
            for (int i = 0; i < LayoutUnit.PlayerUnit.Length; i++)
            {
                Debug.Log(LayoutUnit.PlayerUnit[i]?[0].gameObject.name + " " + Unit[TansferPointIdUnit].gameObject.name);
                if (LayoutUnit.PlayerUnit[i]?[0].gameObject.name  == Unit[TansferPointIdUnit].gameObject.name)
                {
                    LayoutUnit.PlayerUnit[i][0] = null;
                    Debug.Log("Element " + true);
                }
                
            }
            
        }
    }
}