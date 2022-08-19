using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [SerializeField] private int Speed;
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Speed * Time.deltaTime); 
    }
}
