using UnityEngine;
using HSRM.Scripts.mabentiv.Events;
using UnityEngine.Events;
using HSRM.Scripts.mabentiv.Commands;
using System.Collections.Generic;

//make new script without destroying but activating/deactivating go
namespace HSRM.Scripts.mabentiv.Utils
{
    public class Destroy : BaseCommand
    {
        [SerializeField] private List<GameObject> go = null;
        // private bool active = true; 

        protected override void ExecuteCommand()
        {
            //active = !active;
            if (go != null)
            {
                foreach (GameObject gameOb in go)
                {
                    Destroy(gameOb);
                    //gameOb.SetActive(active);
                }
            }
        }
    }
}
