using HSRM.Scripts.mabentiv.Events;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Interactables
{
    public class InteractableToggle : BaseInteractable
    {
        public BoolEvent OnValueChanged = null;

        [SerializeField] private bool boolValue = false;

        public bool BoolValue
        {
            get => boolValue;
            set
            {
                if (IsInteractable)
                {
                    boolValue = value;
                    TriggerStateChanged();
                }
            }
        }
        public void ToggleValue()
        {
            BoolValue = !boolValue;
        }

        private void TriggerStateChanged()
        {
            OnValueChanged?.Invoke(boolValue);
        }
    }
}
