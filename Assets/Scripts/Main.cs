using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ���̳�MonoBehaviour�ĵ���ģʽ
        TestMgr.Instance.TestLog();
        TestMgr2.Instance.TestLog();
        // ע��: ���ڿ����Լ�ȥnewһ������ģʽ�����, �������������ƻ��˵���ģʽ��Ψһ��(���Ƽ�)
        // TestMgr t = new TestMgr(); 
        // BaseManager<TestMgr> t2 = new BaseManager<TestMgr>(); 
        #endregion

        #region �̳�MonoBehaviour�ĵ���ģʽ
        Test2Mgr.Instance.TestLog();
        Test2Mgr2.Instance.TestLog();
        #endregion
    }
}
