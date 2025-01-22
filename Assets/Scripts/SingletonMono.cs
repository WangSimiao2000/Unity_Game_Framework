using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �̳�MonoBehaviour�ĵ�������(�ֶ������ڳ����е�GameObject��)

#region ע��: ����ʽ�ĵ�������
// 1. ����ʹ��new()��ʵ����, ��ΪMonoBehaviour��ʵ������ͨ��Unity������ʵ�ֵ�
// 2. һ���ù�����GameObject��, ͨ��GameObject��ʵ����
#endregion

#region Ǳ������: ����ʽ�ĵ�������
// ����ʽ�ĵ�������: ���ƻ�����ģʽ��Ψһ��
// 1. ��һ��GameObject�Ϲ��ض���̳���SingletonMono����, �ᵼ�º�����า��ǰ�����
// 2. �л�����ʱ, ���ڳ��������˹�����SingletonMono��GameObject, ���л�����ʱ, �ᵼ�µ����������ʵ����
// 3. �ýű���̬��Ӷ���ýű�, Ҳ���ƻ�������Ψһ��
#endregion

#region �������
// 1. ͬһ��GameObject�Ϲ��ض��: Ϊ�ű��������[DisallowMultipleComponent]
// 2. ���GameObject�Ϲ���: �ж�������ڶ���, ���Ƴ��ű�
#endregion

// ��������ͬһ��GameObject�Ϲ��ض���ýű�
[DisallowMultipleComponent]
public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    protected virtual void Awake()
    {
        // ����Ѿ����ڵ���ģʽ����ʵ��, �����ٵ�ǰʵ��
        if (instance != null)
        {
            Destroy(this); // ����Destroy(this.gameObject), ��Ϊֻ��Ҫ�Ƴ��ű�����
            return;
        }
        instance = this as T;
        // ���ؼ̳д˵�������ű�ʱ, �����Ķ������л�����ʱ���ᱻ����
        // ���Ա�֤����Ϸ��������������, �������Ψһ��
        DontDestroyOnLoad(this.gameObject);
    }
}
