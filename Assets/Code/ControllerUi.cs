using Assets.Code.Unit;
using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Assets.Code
{
    public class ControllerUi : MonoBehaviour 
    {
        public static ControllerUi instanse;

        [SerializeField] private TextMeshProUGUI _money;
        [SerializeField] private TextMeshProUGUI _CountUnit;
        [SerializeField] private RectTransform _coinCunter;
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

        public void UpdateCountInventory(int InventoryCount)
        {
            _CountUnit.text = $"{InventoryCount}";
        }

    }
}