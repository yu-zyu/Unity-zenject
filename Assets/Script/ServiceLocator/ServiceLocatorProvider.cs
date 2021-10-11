using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocatorProvider : SingletonMonoBehaviour<ServiceLocatorProvider>
{
    public ServiceLocator Current { get; private set; }

    private void Awake()
    {
        Current = new ServiceLocator();
        // 依存関係を登録
        Current.Register<IInputProvider>(new UnityInputProvider());
    }
}