using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class HttpResorceInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        // ResourceProvider���R���e�i�ɓo�^
        // ��x�����ResourceProvider�̓V���O���g���Ƃ��Ďg���܂킷
        Container.Bind<ResourceProvider>().AsSingle();

        // IResourceClient<string>�ɂ�HttpClient<string> ���g���悤�ɓo�^����
        // ��x�����HttpClient�̓V���O���g�������Ďg���܂킷
//        Container.Bind<IResourceClient<string>>().To<HttpClient<string>>().AsSingle();
        
        //base.InstallBindings();
    }

}

internal class HttpClient<T>
{
}

internal interface IResourceClient<T>
{
}