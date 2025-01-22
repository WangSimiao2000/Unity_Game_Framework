using System;
using System.Reflection;
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

#region �������
// 1. �������Ϊ������, �������ǲ��ܱ�new��
// 2. �涨, �̳е���ģʽ�������, ������ʽ��ʵ��˽�е��޲ι��캯��
// 3. �ڻ�����ͨ������������˽�е��޲ι��캯��, �Դ�ʵ�������� (ʹ��Type���GetConstructor()����)
// ConstructorInfo constructor = typeof(T).GetConstructor(
// BindingFlags.Instance | BindingFlags.NonPublic,  // ��ʾ��Ա˽�з���(Instance)�ͷǹ�������(NonPublic): ��Ϊ�޲ι��캯����˽�е�
// null,                                            // ��ʾ����Ҫ�󶨶���
// Type.EmptyTypes,                                 // ��ʾû�в���
// null);                                           // ��ʾû�в������η�(��out, ref)
#endregion

public abstract class BaseManager<T> where T: class // , new()
{
    private static T instance;

    // ͨ�����Ի�ȡʵ�� ��ѡ��һ
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                // instance = new T();

                // ���÷���õ�˽�е��޲ι��캯��, �Դ�ʵ��������
                Type type = typeof(T);
                ConstructorInfo info =  type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, 
                                                            null, 
                                                            Type.EmptyTypes, 
                                                            null);
                if (info != null)
                {
                    instance = info.Invoke(null) as T;
                }
                else
                {
                    Debug.LogError("The constructor is not found!");
                }
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