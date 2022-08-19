using System.Collections;
using UnityEngine;

namespace Assets.Code.Unit
{
    public class CollisionUnit : MonoBehaviour
    {
        private Unit CurentUnit;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Unit unit))
            {
                if (unit.test != true)
                {
                  var a =   other.contactOffset;

                    Debug.Log("Offset" + a);
                    unit.test = true;
                    unit.transform.position = new Vector3(transform.position.x + Random.Range(0, 1f), transform.position.y, transform.position.z + Random.Range(0, 1f));
                    unit.test = false;
                    //unit.TestMovePoint();
                }
            }
        }
    }
}