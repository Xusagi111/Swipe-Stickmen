using UnityEngine;
public enum ValueRotate { One, Two, Three, Four }

public class LayoutUnit : MonoBehaviour
{
    public Transform[] layouteTransfetPoint;

    public Transform[][] PlayerUnit = new Transform[20][];

    private void Start()
    {
        CreatePointPlayer();
    }
    static class TestCreatePoint
    {
        public static int Circle = 0;

        public static void CheckRotatePoint(int Z, int X, ref ValueRotate valueRotate)
        {
            switch (valueRotate)
            {
                case ValueRotate.One:
                    if (Z == 0 )
                    {
                        valueRotate = ValueRotate.Two;
                    }
                    break;
                case ValueRotate.Two:
                    if (X == 0)
                    {
                        valueRotate = ValueRotate.Three;
                    }
                    break;
                case ValueRotate.Three:
                    if (Z == 0)
                    {
                        valueRotate = ValueRotate.Four;
                    }
                    break;
                case ValueRotate.Four:
                    if (X == 0)
                    {
                        valueRotate = ValueRotate.One;
                        Circle++;
                    }
                    break;
            }
        }
    }

    private ValueRotate valueRotate = ValueRotate.One;
    public int StartZPoint = 4;
    public int StartXPoit = -1;
    //шаг
    [SerializeField] public int YUp = 2;
    [SerializeField] public int XUp = 2;
    private void CreatePointPlayer()
    {
        layouteTransfetPoint = new Transform[16];
        for (int i = 0; i < 16; i++)
        {
            TestCreatePoint.CheckRotatePoint(StartZPoint, StartXPoit, ref valueRotate);
            switch (valueRotate)
            {
                case ValueRotate.One:
                    StartZPoint -= YUp; StartXPoit += XUp;
                    break;
                case ValueRotate.Two:
                    StartZPoint -= YUp; StartXPoit -= XUp;
                    break;
                case ValueRotate.Three:
                    StartZPoint += YUp; StartXPoit -= XUp; 
                    break;
                case ValueRotate.Four:
                    StartZPoint += YUp; StartXPoit += XUp; 
                    break;
            }
            Transform CreatPoint = new GameObject().transform;
            CreatPoint.position = new Vector3(StartXPoit, 0, StartZPoint);
            layouteTransfetPoint[i] = CreatPoint;
        }
    }
    private void LateUpdate()
    {
        for (int i = 0; i < PlayerUnit.Length; i++)
        {
            if (PlayerUnit[i]?[0] != null)
            {
                PlayerUnit[i][0].position = PlayerUnit[i][1].position;
            }
        }
      
    }
}
