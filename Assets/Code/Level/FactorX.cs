using UnityEngine;

namespace Assets.Code.Level
{
    public enum CurrentFactorX
    {
        Plus, Minus, Multiplication
    }

    public class FactorX : MonoBehaviour
    {
        [SerializeField] private  CurrentFactorX _currentFactorX;
        [SerializeField] private int CountUnitsToActiveBlock;
        public int CurrentContactUnit { get; private set; }
        private bool isSentRequestToTheControllerToInteractWithUnits;
        

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out NewUnit unit))
            {
                CurrentContactUnit++;
                CheckUnitsToEndLine();
                return;
            }
        }

        private void CheckUnitsToEndLine()
        {
            if (CurrentContactUnit == CountUnitsToActiveBlock)
            {
                isSentRequestToTheControllerToInteractWithUnits = true;

                //TODO вызвать контроллер который отвечает за добавление текущего кол-ва войск. 
                // Передаваит _currentFactorX.
            }
        }
    }
}