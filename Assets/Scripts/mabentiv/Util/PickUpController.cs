using System.Collections;
using System.Collections.Generic;
using HSRM.Scripts.mabentiv.Commands;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Util
{
    public class PickUpController : BaseCommand
    {
        [SerializeField] private Transform player, itemContainer, targetCamera;

        [SerializeField] private bool pickedUp;
        [SerializeField] private static bool slotFull;


        private void PickUp()
        {
            pickedUp = true;
            slotFull = true;

            transform.SetParent(itemContainer);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.Euler(Vector3.zero);
            transform.localScale = Vector3.one;
        }

        protected override void ExecuteCommand()
        {
            if (!pickedUp && !slotFull) PickUp();
        }
    }
}
