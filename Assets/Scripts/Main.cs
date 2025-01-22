using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestMgr.Instance.TestLog();
        TestMgr2.Instance.TestLog();
        
        Test2Mgr.Instance.TestLog();
        Test2Mgr2.Instance.TestLog();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
