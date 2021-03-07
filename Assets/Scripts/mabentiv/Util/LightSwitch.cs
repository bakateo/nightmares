using System.Collections.Generic;
using HSRM.Scripts.mabentiv.Commands;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Util
{
    public class LightSwitch : BaseCommand
    {
        [SerializeField] private List<Light> lights = null;
        [SerializeField] private bool isOn = false;

        protected override void ExecuteCommand()
        {
            isOn = !isOn;
            foreach(var light in lights)
            {
                light.enabled = isOn;
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
