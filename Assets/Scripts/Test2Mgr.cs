using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2Mgr : SingletonMono<Test2Mgr>
{
    private int i;

    protected override void Awake()
    {
        base.Awake(); // ��дʱ, һ��Ҫ���û����Awake()
        i = 10;
    }

    public void TestLog()
    {
        Debug.Log("Test2Mgr: i=" + i);
    }
}
