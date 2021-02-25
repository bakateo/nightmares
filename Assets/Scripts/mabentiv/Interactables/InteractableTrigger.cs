using UnityEngine.Events;

namespace HSRM.Scripts.mabentiv.Interactables
{

    public class InteractableTrigger : BaseInteractable
    {
        public UnityEvent OnTrigger = null;

        public void Trigger()
        {
            if (IsInteractabel)
            {
                OnTrigger?.Invoke();
            }
        }
    }
}
