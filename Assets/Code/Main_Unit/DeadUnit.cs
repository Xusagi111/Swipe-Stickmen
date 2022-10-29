using System.Collections;
using UnityEngine;

namespace Assets.Code.Main_Unit
{
    public class DeadUnit : MonoBehaviour
    {
        public static DeadUnit instance;

        private void Awake()
        {
            if (instance != null) Destroy(instance);

            instance = this;
        }

        public void DeadCurrentUnit(float uidUnit)
        {
            var AllUnit = AllData.instanse.CurrentUnitGamePlay;

            foreach (var item in AllUnit)
            {
                if (uidUnit == item.UidUnit)
                {
                    Destroy(item.gameObject);
                    AllUnit.Remove(item);
                    return;
                }
            }
            
        }
    }
}