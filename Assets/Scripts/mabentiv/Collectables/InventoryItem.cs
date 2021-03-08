using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HSRM.Scripts.mabentiv.Collectables
{
    [CreateAssetMenu(fileName = "InventoryItem", menuName = "ScriptableObjects/Inventory Item", order = 1)]
    public class InventoryItem : ScriptableObject
    {
        [SerializeField] private string itemName = string.Empty;

        public string ItemName => itemName;
    }
}
