using UnityEngine;

namespace Assets.Code
{
    public interface IUnit
    {
        public CommandUnit commandUnit { get; set; }
        public float countHp { get; set; }
        public Material MaterialUnit { get; set; }
        public Transform UnitPosition { get; set; }
    }
}
