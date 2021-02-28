using HSRM.Scripts.mabentiv.Events;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Commands
{
    public class SetAnimatorBoolCommand : BaseSetAnimatorCommand
    {
        public BoolEvent OnExecute = null;

        [SerializeField] private bool boolValue = true;

        public bool BoolValue { get => boolValue; set => boolValue = value; }

        protected override void ExecuteCommand()
        {
            animator.SetBool(parameterName, BoolValue);
            OnExecute?.Invoke(BoolValue);
        }
    }
}
