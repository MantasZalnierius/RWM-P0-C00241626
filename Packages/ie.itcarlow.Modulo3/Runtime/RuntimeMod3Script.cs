using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modulo3
{
    public static int getMod3(int x)
    {
        int ans1 = x / 3;
        ans1 = ans1 * 3;
        int ans2 = x - ans1;
        return ans2;
    }

    public static int[] mod3(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = getMod3(xs[i]);
        }
        return result;
    }
}

