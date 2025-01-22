using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �Զ�����ʽ�ļ̳�MonoBehaviour�ĵ���ģʽ����
/// 1. �����ֶ�����(�����ֶ�����)
/// 2. ���趯̬���
/// 3. ��������л���������������
/// </summary>
/// <typeparam name="T"></typeparam>

public class SingletonAutoMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                #region ��̬���� ��̬����
                // �ڳ����ϴ���һ���յ�GameObject
                GameObject obj = new GameObject();
                // ���ø�GameObject������(����)
                obj.name = typeof(T).ToString();
                // ��̬���ض�Ӧ�ĵ���ģʽ�ű�
                instance = obj.AddComponent<T>();
                // �������л�ʱ������, ��֤��������Ϸ���������ж�����
                DontDestroyOnLoad(obj);
                #endregion
            }
            return instance;
        }
    }
}
