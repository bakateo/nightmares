using HSRM.Scripts.mabentiv.Interactables;


namespace HSRM.Scripts.mabentiv.Commands
{

    public class UseInteractableToggleCommand : BaseUseInteractableCommand
    {
        private InteractableToggle InteractableToggle => Interactable as InteractableToggle;

        public override bool CanUseInteractable(BaseInteractable interactable)
        {
            return interactable is InteractableToggle;
        }

        protected override void ExecuteCommand()
        {
            InteractableToggle.ToggleValue();
        }
    }
}
