using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code._3d_My_Layoute
{
    public class MainLayoute : MonoBehaviour
    {
        public List<CreatePointToUnit> list { get; set; } = new List<CreatePointToUnit>();
        public static MainLayoute instanse;
        private void Awake()
        {
            if (instanse != null) Destroy(instanse);

            instanse = this;
        }
        private void LateUpdate()
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int n = 0; n < list[i].PlayerUnit.Length; n++)
                {
                    if (list[i].PlayerUnit[n] != null)
                    {
                        list[i].PlayerUnit[n][0].transform.position = list[i].PlayerUnit[n][1].transform.position;
                    }
                }
                
            }
        }

    }
}