using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code
{
    public class BasePool<T> : MonoBehaviour  where T: Component
    {
        public static BasePool<T> instanсe;

        List<T> ListUnitComponents;
        [SerializeField] private GameObject ComponentUnit;
        [SerializeField] private int CountCreateBlocks = 10;
        [SerializeField] private bool isUiGameobject;

        private void Awake()
        {
            if (instanсe != null) Destroy(instanсe);

            instanсe = this;

            Initialization();
        }

        private void Initialization()
        {
            ListUnitComponents = new List<T>(CountCreateBlocks);
            CreateFixedCountComponent(CountCreateBlocks);
        }

        public T UnitComponent
        {
            get
            {
                if (ListUnitComponents.Count != 0)
                {
                    T GetBlock = ListUnitComponents[0];
                    ListUnitComponents.Remove(GetBlock);
                    return GetBlock;
                }
                else
                {
                    CreateFixedCountComponent(5);
                    T GetBlock = ListUnitComponents[0];
                    ListUnitComponents.Remove(GetBlock);
                    return GetBlock;
                }
            }
            set
            {
                DisableGetComponent(((Component)value).gameObject);
                ListUnitComponents.Add(value);
            }
        }
        private void CreateFixedCountComponent(int CountCreate)
        {
            for (int i = 0; i < CountCreateBlocks; i++)
            {
                T CreateBlock = Instantiate(ComponentUnit, Vector3.one, Quaternion.identity, transform).GetComponent<T>();
                
                ((Component)CreateBlock).gameObject.SetActive(false);

                ListUnitComponents.Add(CreateBlock);
            }
        }
        private void DisableGetComponent(GameObject UnitComponent)
        {
            UnitComponent.gameObject.SetActive(false);
            UnitComponent.transform.SetParent(this.transform);
            UnitComponent.gameObject.transform.position = Vector3.zero;

            UnitComponent.transform.localScale = isUiGameobject ? UnitComponent.transform.localScale : Vector3.zero;
        }
    }
}