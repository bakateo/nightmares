using HSRM.Scripts.mabentiv.Collectables;
using HSRM.Scripts.mabentiv.Interactables;
using UnityEngine;
using UnityEngine.Events;

namespace HSRM.Scripts.mabentiv.Events
{
    [SerializeField] public class InteractableEvent : UnityEvent<BaseInteractable> { }
    [SerializeField] public class CollectableEvent : UnityEvent<Collectable> { }

    [SerializeField] public class BoolEvent : UnityEvent<bool> { }
    [SerializeField] public class FloatEvent : UnityEvent<float> { }
    [SerializeField] public class IntEvent : UnityEvent<int> { }

    [SerializeField] public class ColliderEvent : UnityEvent<Collider> { }
}
