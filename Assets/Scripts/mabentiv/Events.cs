using HSRM.Scripts.mabentiv.Collectables;
using UnityEngine;
using UnityEngine.Events;

namespace HSRM.Scripts.mabentiv
{
    public static class Events
    {
        [SerializeField] public class CollectableEvent : UnityEvent<Collectable> { }
    }
}
