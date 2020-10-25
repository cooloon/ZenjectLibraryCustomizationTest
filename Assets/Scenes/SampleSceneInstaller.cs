using UnityEngine;
using Zenject;

namespace Scenes
{
    [CreateAssetMenu(fileName = "SampleSceneInstaller", menuName = "Installers/SampleSceneInstaller")]
    public class SampleSceneInstaller : ScriptableObjectInstaller<SampleSceneInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<User>()
                .FromNewComponentOnNewGameObject()
                .AsSingle()
                .NonLazy();

            Container
                .Bind<Library.Facade>()
                .FromSubContainerResolve()
                .ByInstaller<Library.Installer>()
                .AsSingle();

            // Comment out this binding to use library default value
            Container
                .Bind<Library.IUserCustomization>()
                .To<UserCustomization>()
                .AsSingle();
        }
    }
}
