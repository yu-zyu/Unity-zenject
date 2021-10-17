using UnityEngine;
using Zenject; // Zenjectをusing

public class Injected : MonoBehaviour
{
    // 依存性注入するフィールドにはInjectアトリビュートを付ける
    // これがZenjectが依存性注入する際の目印となる
    [Inject]
    private IExample _example;

    void Update()
    {
        Debug.Log(_example);
    }
}

public interface IExample{} // Injectedが知ることのできるインタフェース
public class Example : IExample{} // Injectedに注入されるクラス

