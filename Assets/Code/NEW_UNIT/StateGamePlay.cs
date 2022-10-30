using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.NEW_UNIT
{
    public class StateGamePlays : MonoBehaviour
    {
        public  bool isActiveGame { get; private set; }
        public  bool isEndGame { get; private set; }

        private List<NewUnit> _allUnit = new List<NewUnit>();



        public void initialization(List<NewUnit> AllUnits)
        {
            isActiveGame = true;
            isEndGame = false;

            _allUnit = AllUnits;
        }

        public void FixedUpdate()
        {
            if (isActiveGame)
            {
                if (_allUnit.Count == 0)
                {
                    isEndGame = true;
                    isActiveGame = false;

                    //TODO Добавить возможность отправлять состоянии игры в контроллер ui.
                }
            }
        }
    }
}

