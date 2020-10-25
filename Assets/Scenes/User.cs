using UnityEngine;

namespace Scenes
{
    public class User : MonoBehaviour
    {
        [Zenject.Inject]
        Library.Facade library;

        void Awake()
        {
            library.SayHello();
        }
    }
}
