using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Assets.Code
{
    public class AllData : MonoBehaviour
    {
        public static AllData instanse;

        public GameObject PlayerCommand;

        public TextMeshProUGUI CountPlayerUnit;

        public GameObject Unit;

        public int PlayerCommand111;

        public List<NewUnit> CurrentUnitGamePlay { get; set; } = new List<NewUnit>();

        private void Awake()
        {
            if (instanse != null) Destroy(instanse);

            instanse = this;
        }
    }
}