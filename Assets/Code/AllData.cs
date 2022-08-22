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

        private void Awake()
        {
            if (instanse != null) Destroy(instanse);

            instanse = this;
        }
    }
}