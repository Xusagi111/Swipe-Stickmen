using System.Collections;
using UnityEngine;

namespace Assets.Code._3d_My_Layoute
{
    public static class SwitchingQuarter
    {
        public static int CountCircle = 0;

        public static void CheckRotatePoint(float Z, float X, ref ValueRotate valueRotate, ref float a)
        {
            switch (valueRotate)
            {
                case ValueRotate.One:
                    if (Z == 0) valueRotate = ValueRotate.Two;
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
}