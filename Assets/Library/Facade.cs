using UnityEngine;

namespace Library
{
    public class Facade
    {
        [Zenject.Inject]
        IUserCustomization userCustomization;

        public void SayHello()
            => Debug.Log($"Hello to [{userCustomization.greetTarget}]!");
    }
}
