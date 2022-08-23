using Assets.Code.Unit;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Unit unit))
        {
            ControllerUnit.FindObjectOfType<ControllerUnit>().CurrentUnitPlayer.Remove(unit);
        }
    }
}
