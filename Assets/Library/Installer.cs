using Zenject;

namespace Library
{
    public class Installer : Installer<Installer>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<Facade>()
                .AsSingle();

            Container
                .Bind<IUserCustomization>()
                .To<CustomizationDefaultValue>()
                .AsSingle()
                .IfNotBound();
        }
    }
}
