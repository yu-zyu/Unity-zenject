using Zenject;

public class ExampleInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<IExample>() // InjectアトリビュートがついているIExample型のフィールドに
            .To<Example>() // Exampleクラスのインスタンスを注入する
            //.To<Magical>() // Exampleクラスのインスタンスを注入する
            .AsTransient();
    }
}
