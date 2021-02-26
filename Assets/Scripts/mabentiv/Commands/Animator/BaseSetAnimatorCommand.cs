using UnityEngine;

namespace HSRM.Scripts.mabentiv.Commands
{
    public abstract class BaseSetAnimatorCommand : BaseCommand
    {
        [SerializeField] protected Animator animator = null;
        [SerializeField] protected string parameterName = string.Empty;

        private void Awake()
        {
            UpdateReference();
        }

        private void OnValidate()
        {
            UpdateReference();
        }

        private void UpdateReference()
        {
            if(animator == null)
            {
                animator = GetComponentInParent<Animator>();
            }
        }

    }
}
