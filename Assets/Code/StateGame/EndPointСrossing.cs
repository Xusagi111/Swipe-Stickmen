using System.Collections;
using UnityEngine;

namespace Assets.Code.StateGame
{
    public class EndPointСrossing : TermsWin
    {
        private Transform _mainPlayerElement;
        private Transform _endPositionGame;

        public override void CheckToWin()
        {
           
        }

        public override void Initialization(GameObject OneElement, GameObject TwoElement)
        {
            _mainPlayerElement = OneElement.transform;
            _endPositionGame = TwoElement.transform;
        }
    }
}