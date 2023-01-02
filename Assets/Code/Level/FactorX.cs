using Assets.Code.Main_Unit;
using UnityEngine;

namespace Assets.Code.Level
{
    public enum FactorXEn
    {
        Plus, Minus, Multiplication
    }

    public class FactorX : MonoBehaviour
    {
        [SerializeField] private FactorXEn _currentFactorX;
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

                StateUnitPlayer.instance.HandlerFactorX(_currentFactorX, CountUnitsToActiveBlock);
                Destroy(this.gameObject);

                //TODO вызвать контроллер который отвечает за добавление текущего кол-ва войск. 
                // Передаваит _currentFactorX.
            }
        }
    }
}