using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class HttpResorceInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        // ResourceProviderをコンテナに登録
        // 一度作ったResourceProviderはシングルトンとして使いまわす
        Container.Bind<ResourceProvider>().AsSingle();

        // IResourceClient<string>にはHttpClient<string> を使うように登録する
        // 一度作ったHttpClientはシングルトンをして使いまわす
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