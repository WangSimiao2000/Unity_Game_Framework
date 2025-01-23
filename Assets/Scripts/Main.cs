using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 不继承MonoBehaviour的单例模式
        TestMgr.Instance.TestLog();
        TestMgr2.Instance.TestLog();
        // 注意: 由于可以自己去new一个单例模式类对象, 以下两个操作破坏了单例模式的唯一性(不推荐)
        // TestMgr t = new TestMgr(); 
        // BaseManager<TestMgr> t2 = new BaseManager<TestMgr>();
        #endregion

        #region 继承MonoBehaviour的单例模式
        Test2Mgr.Instance.TestLog();
        Test2Mgr2.Instance.TestLog();
        #endregion
    }
}
