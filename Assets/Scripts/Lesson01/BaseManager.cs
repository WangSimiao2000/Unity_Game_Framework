using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 用泛型来实现所有Manager的基类

#region 作用
// 1. 主要避免代码冗余
// 2. 泛型为可变的, 所以可以用来实现所有Manager的基类
#endregion

#region 注意
// 限制泛型T必须是类，且必须有一个无参构造函数, 以便在Instance属性中实例化
# endregion

#region 潜在问题:
// 1. 可能会有出现在别的地方 new() 一个单例类的情况, 但是这样会破坏单例的原则
// 2. 多个线程同时访问同一个单例类的情况时, 可能会出现共享资源的安全问题
#endregion

public class BaseManager<T> where T: class, new()
{
    private static T instance;

    // 通过属性获取实例 任选其一
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

    // 通过方法获取实例 任选其一
    //public static T GetInstance()
    //{
    //    if (instance == null)
    //    {
    //        instance = new T();
    //    }
    //    return instance;
    //}
}