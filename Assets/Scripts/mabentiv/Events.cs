using HSRM.Scripts.mabentiv.Collectables;
using HSRM.Scripts.mabentiv.Interactables;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace HSRM.Scripts.mabentiv.Events
{
    [Serializable] public class InteractableEvent : UnityEvent<BaseInteractable> { }
    [Serializable] public class CollectableEvent : UnityEvent<Collectable> { }

    [Serializable] public class BoolEvent : UnityEvent<bool> { }
    [Serializable] public class FloatEvent : UnityEvent<float> { }
    [Serializable] public class IntEvent : UnityEvent<int> { }

    [Serializable] public class ColliderEvent : UnityEvent<Collider> { }
}
