using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMgr: BaseManager<TestMgr>
{
    public void TestLog()
    {
        Debug.Log("TestMgr: TestLog");
    }
}
