using Assets.Code._3d_My_Layoute;
using UnityEngine;
public enum ValueRotate { One, Two, Three, Four }
//TODO Добавить выборку начала спавна точек.
public class CreatePointToUnit
{
    public Transform[] layouteTransfetPoint { get; set; }

    public Transform[][] PlayerUnit { get; set; }

    private ValueRotate valueRotate = ValueRotate.One;
    private float StartZPoint = 3;
    private float StartXPoit = 0;

    //Шаг
    private float YUp = 1f;
    private float XUp = 1f;
    private int CurrentCountPlayer = 96;

    public CreatePointToUnit(float StartZPoint, float StartXPoit, float YUp, float XUp, int CurrentCountPlayer)
    {
        this.StartZPoint = StartZPoint;
        this.StartXPoit = StartXPoit;
        this.YUp = YUp;
        this.XUp = XUp;
        this.CurrentCountPlayer = CurrentCountPlayer;
        PlayerUnit = new Transform[CurrentCountPlayer][];
    }
    public CreatePointToUnit()
    {
        PlayerUnit = new Transform[96][];
    }
    public void CreatePointPlayer()
    {
        GameObject ParentPointSpawnUnit = new GameObject();
        ParentPointSpawnUnit.name = "SpawnPointUnit"; //Реализован поиск по имени.
        SwitchingQuarter.CountCircle = 0;
        layouteTransfetPoint = new Transform[CurrentCountPlayer];
        for (int i = 0; i < CurrentCountPlayer; i++)
        {
            SwitchingQuarter.CheckRotatePoint(StartZPoint, StartXPoit, ref valueRotate, ref StartZPoint);
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
            CreatPoint.gameObject.name = "PointUnit  " + (1 + i);
            CreatPoint.SetParent(ParentPointSpawnUnit.transform);

            CreatPoint.transform.position += new Vector3(CreatPoint.transform.position.x, CreatPoint.transform.position.y + 1.5f);
            CreatPoint.position = new Vector3(StartXPoit, 0, StartZPoint);
            layouteTransfetPoint[i] = CreatPoint;
        }
    }
}
