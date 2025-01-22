using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMgr: BaseManager<TestMgr>
{
    private List<object> list = new List<object>();
    private TestMgr()
    {
        Debug.Log("TestMgr: Constructor");
    }
    public void TestLog()
    {
        Debug.Log("TestMgr: TestLog");
    }

    public void AddData(object data)
    {
        lock (lockObj) // �����ж���ļ�������
        {
            list.Add(data);
        }
    }
}
