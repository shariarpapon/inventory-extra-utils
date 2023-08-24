using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XEntity.InventoryItemSystem
{
    /*
     * IMPORTANT:
     * FIRST go to ItemContainer.cs script and change the "protected ItemSlot[] slots" to "public ItemSlot[] slots"        
     */

    /// <summary>
    /// This class contains some extra utility functions for the inventory.
    /// </summary>
    public static class InventoryExtraUtils
    {

        /// <summary>
        /// Removes the given amount of items from the first slot that holds an item of the given type.
        /// </summary>
        public static void RemoveItemFromContainer(ItemContainer container, ItemType type, int amount)
        {
            ItemSlot slot = FindSlotWithItemType(container, type);
            if (slot != null)
            {
                slot.Remove(amount);
            }
        }

        /// <summary>
        /// Removes 1 item from the first slot that holds an item of the given type.
        /// </summary>
        public static void RemoveItemFromContainer(ItemContainer container, ItemType type) 
        {
            RemoveItemFromContainer(container, type, 1);
        }

        /// <returns>The first slot found with given item-type in the given item-container.</returns>
        public static ItemSlot FindSlotWithItemType(ItemContainer container, ItemType type) 
        {
            foreach (ItemSlot slot in container.slots) 
            {
                if (slot.slotItem.type == type)
                    return slot;
            }
            return null;
        }
    }
}
