using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private GameObjectContext _gameObjectContext;

    public override void InstallBindings()
    {
        Container.Bind<Presenter>().FromSubContainerResolve().ByInstanceGetter(GetGameObjectContextContainer).AsSingle();
        Container.Bind<OtherPresenter>().AsSingle();
    }

    DiContainer GetGameObjectContextContainer(InjectContext context)
    {
        // This will inject it only if it hasn't already been injected
        // It should be queued up for injection because it is assumed to be in the initial scene hierarchy
        context.Container.LazyInject(_gameObjectContext);

        return _gameObjectContext.Container;
    }
}
