using UnityEngine;
using HSRM.Scripts.mabentiv.Events;
using UnityEngine.Events;
using HSRM.Scripts.mabentiv.Commands;

namespace HSRM.Scripts.mabentiv.Utils
{
    public class Destroy : BaseCommand
    {
        [SerializeField] private BoxCollider go = null;

        protected override void ExecuteCommand()
        {
            if (go != null)
            {
                Destroy(go);
            }
        }
        private void Update()
        {
            Execute();
        }
    }
}
