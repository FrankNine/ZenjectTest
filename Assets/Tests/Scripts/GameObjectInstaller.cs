using Zenject;

public class GameObjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<View>().FromComponentInHierarchy(includeInactive: true).AsSingle();
        Container.Bind<Presenter>().AsSingle();
        Container.Bind<ViewModel>().AsSingle();
    }
}
