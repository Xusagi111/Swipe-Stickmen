using UnityEngine;

namespace Assets.Code.Static_Class
{
    public static class MainStaticClass
    {
        public static void TransferPoint(Transform ChildrenComponent, Transform ParentComponent, bool isUseParent = false) 
        {
            ChildrenComponent.gameObject.SetActive(false);
            ChildrenComponent.SetParent(ParentComponent);
            ChildrenComponent.gameObject.SetActive(true);
        }
    }
}
