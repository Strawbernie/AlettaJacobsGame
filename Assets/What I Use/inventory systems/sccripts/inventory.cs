using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIMPLE_INVENTORY_DEMO
{
    public class inventory : MonoBehaviour
    {
        private List<string> items = new List<string>();

        public void CreateItem(string item)
        {
            items.Add(item);
        }

        public void DeleteItem(string item)
        {
            items.Remove(item);
        }

        public bool HasItem(string item)
        {
            return items.Contains(item);
        }
    }
}