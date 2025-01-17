using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �÷�����ʵ������Manager�Ļ���

#region ����
// 1. ��Ҫ�����������
// 2. ����Ϊ�ɱ��, ���Կ�������ʵ������Manager�Ļ���
#endregion

#region ע��
// ���Ʒ���T�������࣬�ұ�����һ���޲ι��캯��, �Ա���Instance������ʵ����
# endregion

#region Ǳ������:
// 1. ���ܻ��г����ڱ�ĵط� new() һ������������, �����������ƻ�������ԭ��
// 2. ����߳�ͬʱ����ͬһ������������ʱ, ���ܻ���ֹ�����Դ�İ�ȫ����
#endregion

public class BaseManager<T> where T: class, new()
{
    private static T instance;

    // ͨ�����Ի�ȡʵ�� ��ѡ��һ
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }
    }

    // ͨ��������ȡʵ�� ��ѡ��һ
    //public static T GetInstance()
    //{
    //    if (instance == null)
    //    {
    //        instance = new T();
    //    }
    //    return instance;
    //}
}