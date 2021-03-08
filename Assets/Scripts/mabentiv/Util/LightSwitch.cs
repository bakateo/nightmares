﻿using System.Collections.Generic;
using HSRM.Scripts.mabentiv.Commands;
using HSRM.Scripts.mabentiv.Util;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Util
{
    public class LightSwitch : BaseCommand
    {
        [SerializeField] private List<Light> lights = null;
        [SerializeField] private bool isOn = false;

        protected override void ExecuteCommand()
        {
            Switch();
        }

        protected void Switch()
        {
            if (FuseToggle.fuseOn)
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
