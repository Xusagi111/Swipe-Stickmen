using System.Collections;
using UnityEngine;

namespace Assets.Code
{
    public class MapToTrigger : MonoBehaviour
    {
        public enum TriggerPoint { Solid, DeadBody }
       [field: SerializeField] public TriggerPoint TriggerCollision { get; private set; }
    }
}