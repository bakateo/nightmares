using HSRM.Scripts.mabentiv.Cameras;
using HSRM.Scripts.mabentiv.Utils;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Commands
{
    public class UpdateRaycasterCameraCommand : BaseCommand
    {
        [SerializeField] private CameraController cameraController = null;

        public override bool CanExecute 
        {
            get => base.CanExecute && cameraController != null; 
            set => base.CanExecute = value; 
        }

        protected override void ExecuteCommand()
        {
            if (TryGetRaycaster(out var raycaster))
            { 
                if (cameraController.HasCurrentCameraControl)
                {
                    raycaster.Camera = cameraController.CurrentCameraControl.TargetCamera;
                }
                else 
                {
                    raycaster.Camera = null;
                }
            }
        }

        private bool TryGetRaycaster(out Raycaster raycaster)
        {
            raycaster = FindObjectOfType<Raycaster>();
            return raycaster != null;
        }
    }
}