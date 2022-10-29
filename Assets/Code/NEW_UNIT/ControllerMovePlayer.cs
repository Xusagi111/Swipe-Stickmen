using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.NEW_UNIT
{

    public class ControllerMovePlayer : MonoBehaviour
    {
        public bool isMobileController;

        public GameObject MainGameMove; //MainGameObj
        public Vector2 LeftLimitPosition = new Vector2(-8, 0);
        public Vector2 RightLimitPosition = new Vector2(8, 0);
        public Joystick joystick;
        public float speed = 5;
        public float floatDebug = 5;

        [SerializeField] public List<NewUnit> AllCurrentUnitToPlayerCommand = new List<NewUnit>();

        public float DebugPositionX;

        private void Update()
        {
            MoveMainElement();


            if (MainGameMove.transform.position.x != DebugPositionX)
            {
                MoveAllUnit();
                DebugPositionX = MainGameMove.transform.position.x;
            }
            
        }

        public void  MoveMainElement()
        {
            float Horizontal = !isMobileController ? Input.GetAxis("Horizontal") : joystick.Horizontal;

            if (MainGameMove.transform.position.x <= LeftLimitPosition.x)
            {
                MainGameMove.transform.position = new Vector3(LeftLimitPosition.x, MainGameMove.transform.position.y);
            }

            if (MainGameMove.transform.position.x >= RightLimitPosition.x)
            {
                MainGameMove.transform.position = new Vector3(RightLimitPosition.x, MainGameMove.transform.position.y);
            }

            MainGameMove.transform.position = new Vector3(MainGameMove.transform.position.x + Horizontal * Time.deltaTime * speed, MainGameMove.transform.position.y);
        }

        public void MoveAllUnit()
        {
            foreach (var item in AllCurrentUnitToPlayerCommand)
            {
                item.UpdateTransform(MainGameMove.transform, floatDebug); // .transform.LookAt(MainGameMove.transform); 
            }
        }
    }
}