using UnityEngine;

namespace Assets.Code.Static_Class
{
    public static class MainStaticClass
    {
        public static void TransferPoint(Transform ChildrenComponent, Transform ParentComponent, bool isUseParent = false, Transform MovePoint = null)
        {
            ChildrenComponent.SetParent(ParentComponent);
            ChildrenComponent.gameObject.SetActive(false);

            ChildrenComponent.transform.position = isUseParent ? ParentComponent.position : MovePoint.position ;

            ChildrenComponent.gameObject.SetActive(true);
        }
    }
}
