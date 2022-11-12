using Assets.Code.StateGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.NEW_UNIT
{
    public class StateGamePlays : MonoBehaviour
    {
        public  bool isActiveGame { get; private set; }
        public  bool isEndFalseGame { get; private set; }
        public bool isWinEndGame { get; private set; }


        private List<NewUnit> _allUnit = new List<NewUnit>();
        private TermsWin _teamsWin;


        public void initialization(List<NewUnit> AllUnits, TermsWin teamsWin)
        {
            isActiveGame = true;
            isEndFalseGame = false;

            _allUnit = AllUnits;

            _teamsWin = teamsWin;
        }

        public void FixedUpdate()
        {
            if (isActiveGame)
            {
                if (_teamsWin.CheckToWin())
                {
                    isWinEndGame = true;
                }

                if (_allUnit.Count == 0)
                {
                    isEndFalseGame = true;
                    isActiveGame = false;

                    //TODO Добавить возможность отправлять состоянии игры в контроллер ui.
                }
            }
        }
    }
}

