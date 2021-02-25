using UnityEngine;
using static HSRM.Scripts.mabentiv.Events;

namespace HSRM.Scripts.mabentiv.Collectables
{

    public enum ItemType { Key }

    public class Collectable : MonoBehaviour
    {
        public CollectableEvent OnCollect = null;

        [SerializeField] private ItemType itemType = ItemType.Key;

        public ItemType ItemType => ItemType;

        public void Collect()
        {
            OnCollect?.Invoke(this);
        }
    }
}
