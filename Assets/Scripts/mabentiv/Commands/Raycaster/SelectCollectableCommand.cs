﻿using HSRM.Scripts.mabentiv.Collectables;
using UnityEngine;
using UnityEngine.Events;
using HSRM.Scripts.mabentiv;

namespace HSRM.Scripts.mabentiv.Commands
{
    public class SelectCollectableCommand : BaseSelectionCommand
    {
        public CollectableEvent OnCollectableSelected = null;
        public UnityEvent OnSelectionFailed = null;

        protected override void HandleHit(RaycastHit hit)
        {
            Transform hitTransform = hit.transform;
            if (hitTransform.TryGetComponent<Collectable>(out var collectable))
            {
                HandleCollectable(collectable);
            }
            else
            {
                HandleMiss();
            }
        }

        protected override void HandleMiss()
        {
            HasSelection = false;
            OnSelectionFailed?.Invoke();
        }
        private void HandleCollectable(Collectable collectable)
        {
            HasSelection = true;
            OnCollectableSelected?.Invoke(collectable);
        }
    }
}