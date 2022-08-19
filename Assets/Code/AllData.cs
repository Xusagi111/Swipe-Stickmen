using System.Collections;
using UnityEngine;

namespace Assets.Code
{
    public class AllData : MonoBehaviour
    {
        public static AllData instanse;

        public GameObject PlayerCommand;

        private void Awake()
        {
            if (instanse != null) Destroy(instanse);

            instanse = this;
        }
    }
}