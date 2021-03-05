using UnityEngine;
using HSRM.Scripts.mabentiv.Events;
using UnityEngine.Events;
using HSRM.Scripts.mabentiv.Commands;
using System.Collections.Generic;

namespace HSRM.Scripts.mabentiv.Utils
{
    public class Destroy : BaseCommand
    {
        [SerializeField] private List<Object> go = null;

        protected override void ExecuteCommand()
        {
            if (go != null)
            {
                foreach (Object gameOb in go)
                {
                    Destroy(gameOb);
                }
            }
        }
    }
}
