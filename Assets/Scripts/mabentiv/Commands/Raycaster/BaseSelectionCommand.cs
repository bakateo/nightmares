using UnityEngine;

namespace HSRM.Scripts.mabentiv.Commands
{
    public abstract class BaseSelectionCommand : BaseRaycasterCommand
    {
        public virtual bool HasSelection { get; protected set; } = false;
    }
}