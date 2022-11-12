using UnityEngine;

namespace Assets.Code.StateGame
{
    public abstract class TermsWin : MonoBehaviour
    {
        public bool isWin { get; set; }
        public abstract bool CheckToWin();
        public abstract void Initialization(GameObject OneElement, GameObject TwoElement);
    }

}
