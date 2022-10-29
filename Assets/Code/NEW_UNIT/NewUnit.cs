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
        }

        public void UpdateTransform(Transform ParentTransform, float speed)
        {
            RigidbodyUnit.velocity = (ParentTransform.position - transform.position) * speed;
        }
    }
}