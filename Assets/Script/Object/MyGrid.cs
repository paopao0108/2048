using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGrid : MonoBehaviour
{
    public Number number;
    // 判断是否有数字
    public bool isHasNumber()
    {
        return this.number != null; 
    }

    // 获取格子上的数字
    public Number GetNumber()
    {
        return this.number;
    }

    // 设置格子上的数字
    public void SetNumber(Number number)
    {
        this.number = number;
    }
}
