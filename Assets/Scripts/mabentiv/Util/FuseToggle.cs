using System.Collections;
using System.Collections.Generic;
using HSRM.Scripts.mabentiv.Commands;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Util
{
    public class FuseToggle : BaseCommand
    {
        private GameObject[] lights = null;
        public static bool fuseOn = true;

        public bool FuseOn
        {
            get => fuseOn;
        }

        protected override void ExecuteCommand()
        {
            Switch();
        }

        protected void Switch()
        {
            fuseOn = !fuseOn;
            if(lights == null)
            {
                lights = GameObject.FindGameObjectsWithTag("Light");
            }

            foreach (var light in lights)
            {
                light.SetActive(fuseOn);
            }
        }
    }
}
