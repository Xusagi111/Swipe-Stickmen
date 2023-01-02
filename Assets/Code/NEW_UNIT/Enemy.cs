using Assets.Code.Main_Unit;
using System.Collections;
using UnityEngine;

namespace Assets.Code.NEW_UNIT
{
    public class Enemy : MonoBehaviour
    {
        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.TryGetComponent(out NewUnit unit))
            {
                DeadUnit.instance.DeadCurrentUnit(unit.UidUnit);
            }
        }
    }
}