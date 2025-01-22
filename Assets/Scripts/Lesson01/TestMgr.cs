using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMgr: BaseManager<TestMgr>
{
    private TestMgr()
    {
        Debug.Log("TestMgr: Constructor");
    }
    public void TestLog()
    {
        Debug.Log("TestMgr: TestLog");
    }
}
