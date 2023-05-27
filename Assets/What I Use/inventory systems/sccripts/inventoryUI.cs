using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SIMPLE_INVENTORY_DEMO
{
    public class inventoryUI : MonoBehaviour
    {
        // References to the input field
        [SerializeField] private TMP_InputField inputField;

        // References to create button
        [SerializeField] private Button createButton;

        // References to delete button
        [SerializeField] private Button deleteButton;

        // References to ItemList
        [SerializeField] private Transform itemList;

        // References to item prefab
        [SerializeField] private GameObject itemPrefab;

        // Reference to inventory script
        [SerializeField] private inventory Inventory;

        void Start()
        {

        }

        void CreateItem()
        {
            string item = inputField.text;

            if (!Inventory.HasItem(item)) // Check if inventroy doesn't have the item yet
            {
                Inventory.CreateItem(item); // Add item to the list
                GameObject newItem = Instantiate(itemPrefab, itemList); // Add item ot the inventory user interface
                newItem.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = item; // Add the name to the item
            }
        }

        void DeleteItem()
        {
            string item = inputField.text;
            // Check if inventory list has the item
                // Remove the item from the inventory list
                // Go through the inventory interface and check for the item
                    // Destroy the item
        }
    }
}
