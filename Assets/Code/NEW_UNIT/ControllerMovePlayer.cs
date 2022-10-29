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
        public float SideToSideSpeed = 10;
        public float floatDebug = 2;

        [SerializeField] public List<NewUnit> AllCurrentUnitToPlayerCommand = new List<NewUnit>();

        public float DebugPositionX;

        public int ForwardSpeedMainGameObj;

        private void Start()
        {
            MoveAllUnit();
        }

        private void Update()
        {
            MainGameMove.transform.position = new Vector3(MainGameMove.transform.position.x, MainGameMove.transform.position.y, MainGameMove.transform.position.z + ForwardSpeedMainGameObj * Time.deltaTime);

            MoveMainElement();

            MoveAllUnit();

        }

        public void  MoveMainElement()
        {
            float Horizontal = !isMobileController ? Input.GetAxis("Horizontal") : joystick.Horizontal;

            if (MainGameMove.transform.position.x <= LeftLimitPosition.x)
            {
                MainGameMove.transform.position = new Vector3(LeftLimitPosition.x, MainGameMove.transform.position.y, MainGameMove.transform.position.z);
            }

            if (MainGameMove.transform.position.x >= RightLimitPosition.x)
            {
                MainGameMove.transform.position = new Vector3(RightLimitPosition.x, MainGameMove.transform.position.y, MainGameMove.transform.position.z);
            }

            MainGameMove.transform.position = new Vector3(MainGameMove.transform.position.x + Horizontal * Time.deltaTime * SideToSideSpeed, MainGameMove.transform.position.y, MainGameMove.transform.position.z);
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