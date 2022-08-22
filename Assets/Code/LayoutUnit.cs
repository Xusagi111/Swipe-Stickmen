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
        public static int CountCircle = 0;

        public static void CheckRotatePoint(float Z, float X, ref ValueRotate valueRotate, ref float a)
        {
            switch (valueRotate)
            {
                case ValueRotate.One:
                    if (Z == 0 ) valueRotate = ValueRotate.Two;
                    break;

                case ValueRotate.Two:
                    if (X == 0) valueRotate = ValueRotate.Three;
                    break;

                case ValueRotate.Three:
                    if (Z == 0) valueRotate = ValueRotate.Four;
                    break;
                case ValueRotate.Four:
                    if (X == 0)
                    {
                        valueRotate = ValueRotate.One;

                        a = CountCircle == 0 ? 5 : CountCircle == 1 ? 7 : 9;

                        CountCircle++;
                    }
                    break;
            }
        }
    }

    private ValueRotate valueRotate = ValueRotate.One;
    public float StartZPoint = 3;
    public float StartXPoit = 0;
    //шаг
    public float YUp = 1f;
    public float XUp = 1f;
    public GameObject Unit; // ADD
    private void CreatePointPlayer()
    {
        TestCreatePoint.CountCircle = 0;
        layouteTransfetPoint = new Transform[120];
        for (int i = 0; i < 120; i++)
        {
            TestCreatePoint.CheckRotatePoint(StartZPoint, StartXPoit, ref valueRotate, ref StartZPoint);
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
            CreatPoint.transform.position += new Vector3(CreatPoint.transform.position.x, CreatPoint.transform.position.y + 1.5f);
            CreatPoint.position = new Vector3(StartXPoit, 0, StartZPoint);
            layouteTransfetPoint[i] = CreatPoint;
        }
        CreateGameObj();
    }
    [ContextMenu("CreatePrimitive")]
    private void CreateGameObj()
    {
        for (int i = 0; i < layouteTransfetPoint.Length; i++)
        {
            Instantiate(Unit, layouteTransfetPoint[i].position, Quaternion.identity, this.transform);
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
