using System.Collections;
using UnityEngine;

namespace Assets.Code
{
    public class NewUnit : MonoBehaviour
    {
        public float UidUnit;
        public Rigidbody RigidbodyUnit;

        public void UpdateTransform(Transform ParentTransform, float speed)
        {
            transform.position = Vector3.Lerp(transform.position, ParentTransform.position, 0.1f * Time.deltaTime * speed);
        }
    }
}