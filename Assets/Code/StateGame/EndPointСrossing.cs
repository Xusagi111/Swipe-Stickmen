using System.Collections;
using UnityEngine;

namespace Assets.Code.StateGame
{
    public class EndPointСrossing : TermsWin
    {
        private Transform _mainPlayerElement;
        private Transform _endPositionGame;

        public override bool CheckToWin()
        {
            var CurrentDistanseToEnd = Vector3.Distance(_mainPlayerElement.position, _endPositionGame.position);
            
            if (CurrentDistanseToEnd <= 1)
            {
                return true;
            }

            return false;
          
        }

        public override void Initialization(GameObject OneElement, GameObject TwoElement)
        {
            _mainPlayerElement = OneElement.transform;
            _endPositionGame = TwoElement.transform;
        }
    }
}