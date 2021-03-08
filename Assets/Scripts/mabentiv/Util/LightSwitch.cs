using System.Collections.Generic;
using HSRM.Scripts.mabentiv.Commands;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Util
{
    public class LightSwitch : BaseCommand
    {
        [SerializeField] private List<Light> lights = null;
        [SerializeField] private bool isOn = false;
        private bool fuseOn = true;

        public bool FuseOn
        {
            get => fuseOn;
            set {fuseOn = value; Switch();}
        }

        protected override void ExecuteCommand()
        {
            Switch();
        }

        protected void Switch()
        {
            if (fuseOn)
            {
                isOn = !isOn;
                foreach (var light in lights)
                {
                    light.enabled = isOn;
                }
            }
        }

        void Start()
        {
            foreach (var light in lights)
            {
                light.enabled = isOn;
            }
        }
    }
}
