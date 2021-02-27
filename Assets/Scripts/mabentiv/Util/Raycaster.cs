using HSRM.Scripts.mabentiv.Commands;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Utils
{
    public class Raycaster : MonoBehaviour
    {
        [SerializeField] private Camera targetCamera = null;
        [SerializeField] private GameObject userInterface = null;
        [SerializeField] private MouseClickCommand clickCommand = null;

        public bool IsInteractable
        {
            get => clickCommand.CanExecute;
            set { clickCommand.CanExecute = value; SetUserInterfaceVisible(value); }
        }

        public bool HasCamera => Camera != null;

        public Camera Camera
        {
            get => targetCamera;
            set => targetCamera = value;
        }

        private void SetUserInterfaceVisible(bool visible)
        {
            userInterface.SetActive(visible);
        }
    }
}
