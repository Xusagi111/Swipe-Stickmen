using Assets.Code.Level;
using UnityEngine;

namespace Assets.Code.ControlerFactorX
{
    public class CheckСontacToUnit : MonoBehaviour
    {
        [SerializeField] private FactorX OnefactorX;
        [SerializeField] private FactorX TwofactorX;
        [SerializeField] public bool isActiveGameObject;

        private void Update()
        {
            if (this.gameObject.activeSelf == false)
            {
                return;
            }
            
            CheckContactUnit();
        }

        private void CheckContactUnit()
        {
            if (OnefactorX.CurrentContactUnit >= 10)
            {
                OnEnableObj(false);

            }
            else if(TwofactorX.CurrentContactUnit >= 10)
            {
                OnEnableObj(false);
            }
        }

        private void OnEnableObj(bool state)
        {
            OnefactorX.gameObject.SetActive(state);
            TwofactorX.gameObject.SetActive(state);
            gameObject.SetActive(false);
        }
    }
}