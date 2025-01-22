using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 继承MonoBehaviour的单例基类(挂载在场景中的GameObject上)

#region 注意: 挂载式的单例基类
// 1. 不能使用new()来实例化, 因为MonoBehaviour的实例化是通过Unity引擎来实现的
// 2. 一定得挂载在GameObject上, 通过GameObject来实例化
#endregion

#region 潜在问题: 挂载式的单例基类
// 挂载式的单例基类: 会破坏单例模式的唯一性
// 1. 在一个GameObject上挂载多个继承自SingletonMono的类, 会导致后面的类覆盖前面的类
// 2. 切换场景时, 由于场景放置了挂载了SingletonMono的GameObject, 再切换回来时, 会导致单例类的重新实例化
// 3. 用脚本动态添加多个该脚本, 也会破坏单例的唯一性
#endregion

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
        instance = this as T;
    }
}
