using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGrid : MonoBehaviour
{
    public Number number;
    // �ж��Ƿ�������
    public bool isHasNumber()
    {
        return this.number != null; 
    }

    // ��ȡ�����ϵ�����
    public Number GetNumber()
    {
        return this.number;
    }

    // ���ø����ϵ�����
    public void SetNumber(Number number)
    {
        this.number = number;
    }
}
