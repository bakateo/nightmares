using HSRM.Scripts.mabentiv.Interactables;

namespace HSRM.Scripts.mabentiv.Commands
{
    public abstract class BaseUseInteractableCommand : BaseCommand
    {
        public BaseInteractable Interactable { get; protected set; }

        protected bool HasInteractable => Interactable != null;

        public override bool CanExecute
        {
            get => base.CanExecute && HasInteractable && Interactable.IsInteractable;
            set => base.CanExecute = value;

        }

        public abstract bool CanUseInteractable(BaseInteractable interactable);

        public void TryUseInteractable(BaseInteractable interactabel)
        {
            TrySetInteractable(interactabel);
            Execute();
            ClearInteractable();
        }


        public void TrySetInteractable(BaseInteractable interactable)
        {
            if (CanUseInteractable(interactable))
            {
                Interactable = interactable;
            }
        }

        public void ClearInteractable()
        {
            Interactable = null;
        }
    }
}
