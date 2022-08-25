using Assets.Code;
using UnityEngine;

public class MoveUnit : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private float TestMove;
    [SerializeField] private float MinFlorestrictionsTransverMoveUnit;
    [SerializeField] private float MaxFlorestrictionsTransverMoveUnit;

    private GameObject LinkToMoveCommand;
   [SerializeField] private float MovePosition; //Test Public view component
    private void Start()
    {
        LinkToMoveCommand = AllData.instanse.PlayerCommand;
        //TODO Test
        GameObject CurrentPlayer = GameObject.Find("SpawnPointUnit").gameObject;
        CurrentPlayer.transform.SetParent(LinkToMoveCommand.transform);
    }
    private void FixedUpdate()
    {
        MovePosition = LinkToMoveCommand.transform.position.x + joystick.Horizontal * TestMove;

        if (MovePosition > MaxFlorestrictionsTransverMoveUnit)
        {
            MovePosition = MaxFlorestrictionsTransverMoveUnit;
        }
        else if(MovePosition < MinFlorestrictionsTransverMoveUnit)
        {
            MovePosition = MinFlorestrictionsTransverMoveUnit;
        }

        LinkToMoveCommand.transform.position = new Vector3(MovePosition, LinkToMoveCommand.transform.position.y);
    }
}
