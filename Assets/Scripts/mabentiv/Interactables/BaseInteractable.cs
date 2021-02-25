using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HSRM.Scripts.mabentiv.Interactables {

    public abstract class BaseInteractable : MonoBehaviour
    {
        [SerializeField] private bool isInteractable = true;

        public bool IsInteractabel
        {
            get => isInteractable;
            set => isInteractable = value;
        }
    }
}
