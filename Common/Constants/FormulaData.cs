﻿using System;
namespace Common.Constants
{
    public static class FormulaData
    {
        public static float[] BaseManaRegen = {
            0.020979f,
            0.020515f,
            0.020079f,
            0.019516f,
            0.018997f,
            0.018646f,
            0.018314f,
            0.017997f,
            0.017584f,
            0.017197f,
            0.016551f,
            0.015729f,
            0.015229f,
            0.014580f,
            0.014008f,
            0.013650f,
            0.011840f,
            0.013175f,
            0.012832f,
            0.012475f,
            0.012073f,
            0.011494f,
            0.011292f,
            0.010990f,
            0.010761f,
            0.010546f,
            0.010321f,
            0.010151f,
            0.009949f,
            0.009740f,
            0.009597f,
            0.009425f,
            0.009278f,
            0.009123f,
            0.008974f,
            0.008847f,
            0.008698f,
            0.008581f,
            0.008457f,
            0.008338f,
            0.008235f,
            0.008113f,
            0.008018f,
            0.007906f,
            0.007798f,
            0.007713f,
            0.007612f,
            0.007524f,
            0.007430f,
            0.007340f,
            0.007268f,
            0.007184f,
            0.007116f,
            0.007029f,
            0.006945f,
            0.006884f,
            0.006805f,
            0.006747f,
            0.006667f,
            0.006600f
        };

        public static float RageConversionValue(uint level)
        {
            return (float)(0.0091107836f * Math.Pow(level, 2) + 3.225598133f * level + 4.2652911f);
        }

        public static float ZeroDifferenceValue(uint level)
        {
            if (level < 8)
                return 5;
            if (level < 10)
                return 6;
            if (level < 12)
                return 7;
            if (level < 16)
                return 8;
            if (level < 20)
                return 9;
            if (level < 30)
                return 11;
            if (level < 40)
                return 12;
            if (level < 45)
                return 13;
            if (level < 50)
                return 15;
            if (level < 55)
                return 16;
            if (level < 60)
                return 17;
            return 1;
        }
    }
}
