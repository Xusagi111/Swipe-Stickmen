using UnityEngine;

public class MoveUnit : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private float TestMove;
    private GameObject LinkToMoveCommand;
    private void Start()
    {
        //LinkToMoveCommand = AllData.instanse.PlayerCommand;
        //TODO Test
        LinkToMoveCommand = GameObject.Find("SpawnPointUnit").gameObject;
    }
    private void FixedUpdate()
    {
        LinkToMoveCommand.transform.position = new Vector3(LinkToMoveCommand.transform.position.x + joystick.Horizontal * TestMove, LinkToMoveCommand.transform.position.y);
    }
}
