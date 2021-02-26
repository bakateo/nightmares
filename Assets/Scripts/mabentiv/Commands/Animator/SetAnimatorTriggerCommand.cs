﻿using UnityEngine.Events;

namespace HSRM.Scripts.mabentiv.Commands
{
    public class SetAnimatorTriggerCommand : BaseSetAnimatorCommand
    {
        public UnityEvent OnExecute = null;

        protected override void ExecuteCommand()
        {
            animator.SetTrigger(parameterName);
            OnExecute?.Invoke();
        }
    }
}
