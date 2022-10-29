using System.Collections;
using UnityEngine;

namespace Assets.Code
{
    public class NewUnit : MonoBehaviour
    {
        public float UidUnit;
        public Rigidbody RigidbodyUnit;

        public void Inizialization()
        {
            transform.position += Vector3.forward;
            UidUnit = Random.Range(0, 100000);
        }

        public void UpdateTransform(Transform ParentTransform, float speed)
        {
            RigidbodyUnit.velocity = (ParentTransform.position - transform.position) * speed;
        }
    }
}