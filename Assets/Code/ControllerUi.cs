using Assets.Code.NEW_UNIT;
using Assets.Code.Unit;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Code
{
    public class ControllerUi : MonoBehaviour 
    {
        public static ControllerUi instanse;

        [SerializeField] private TextMeshProUGUI _money;
        [SerializeField] private TextMeshProUGUI _CountUnit;
        [SerializeField] private RectTransform _coinCunter;
        [SerializeField] private GameObject EndPanel;

        private StateGamePlays _stateGame;

        private void Awake()
        {
            if (instanse != null) Destroy(instanse);
            instanse = this;

            ControllerUnit.PlayerUpdateUi += UpdateCountInventory;
        }

        internal void UpdateMoneyText(int money)
        {
            _money.text = money.ToString();
        }

        private void OnDestroy()
        {
            ControllerUnit.PlayerUpdateUi -= UpdateCountInventory;
        }
        
        private void FixedUpdate()
        {
            UpdateCountPlayerUnit();

            if (_stateGame != null && _stateGame.isEndGame == true)
            {
                EndPanel.SetActive(true);
            }
        }

        public void UpdateCountPlayerUnit()
        {
            var countlayerUnit = AllData.instanse.CurrentUnitGamePlay.Count;
            _CountUnit.text = countlayerUnit.ToString();

        }

        public void UpdateCountInventory(int InventoryCount)
        {
            if (InventoryCount == 0)
            {
                EndPanel.SetActive(true);
            }
            _CountUnit.text = $"{InventoryCount}";
        }

        public void ResetLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}