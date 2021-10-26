using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mathfを省略できる
using static UnityEngine.Mathf;

public class Calculation : MonoBehaviour
{
    // PIを返す
    public float UsePI()
    {
        // const float PI = 3.1415926535f;
        // return PI;
        return Mathf.PI;
    }

    // 絶対値を返す
    public float UseAbs(float num)
    {
        // if(num < 0)
        // {
        //     return num = num * -1.0f;
        // }
        // else
        // {
        //     return num;
        // }

        return Mathf.Abs(num);
    }

    //  整数値だけを返す
    public float UseFloor(float num)
    {
        return Mathf.Floor(num);
    }

    // 符号を返す
    // 正の数と0なら1、負の数なら-1を返す。
    public float UseSign(float num)
    {
        // if(num < 0)
        // {
        //     return -1.0f;
        // }
        // else
        // {
        //     return 1.0f;
        // }

        return Mathf.Sign(num);
    }

    // 循環を生み出す方法
    public float UseMod(int x)
    {
        // 答えが0,1,2の循環になる
        // 0 % 3 = 0
        // 1 % 3 = 1
        // 2 % 3 = 2
        // 3 % 3 = 0
        // 4 % 3 = 1
        // 5 % 3 = 2
        // 6 % 3 = 0
        const int num = 3;
        return x % num;
    }

    //値を0~1や-1~1に収める方法、正規化な感じ＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
    // 0~1や-1~1にすると何かと便利、ノーマライズとか使うでしょ？


    // 方法1
    // Sinを使う（Cosでもいい）
    public float UseSin(float num)
    {
        // -1~1になる
        // return Mathf.Sin(num);

        // 0~1にする方法
        return Mathf.Sin(num) + 1.0f / 2.0f;
    }

    // 方法2
    // Signを使う
    // -1か1になる

    // 方法3
    public float UseClamp(float num)
    {
        // -1~1になる
        return Mathf.Clamp(num, -1.0f, 1.0f);
    }
    

}
