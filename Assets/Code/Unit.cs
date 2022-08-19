using UnityEngine;

namespace Assets.Code
{
    public class Unit : MonoBehaviour, IUnit
    {
        [field: SerializeField] public CommandUnit commandUnit { get; set; }
        [field: SerializeField] public float countHp { get; set; }
        [HideInInspector] public Transform UnitPosition { get; set; }
        [HideInInspector] public Material MaterialUnit { get; set; }

        private void Awake()
        {
            UnitPosition = this.transform;
        }
    }
}
