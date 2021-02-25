using UnityEngine;

namespace HSRM.Scripts.mabentiv
{
    public class RayCaster : MonoBehaviour
    {
        [SerializeField] private Camera currentCamera = null;

        public Camera Camera => currentCamera;
    }
}
