using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    IDictionary<Item, int> inventory = new Dictionary<Item, int>();

    void AddItem(Item item, int count)
    {
        if (count == 0) count = 1;

        inventory.Add(item, count);

    }
    void SubItem(string name, int count)
    {
        Item thing = GetItemByName(name);
        if (count == 0)
            count = 1;
        if(thing != null)
            inventory[thing] -= count;
    }

    void RemoveItembyName(string name)
    {
        inventory.Remove(GetItemByName(name));
    }
    Item GetItemByName(string name)
    {
        foreach (KeyValuePair<Item, int> items in inventory)
        {
            Item x = items.Key;
            if (x.name == name)
            {
                return x;
            }

        }
        return null;
    }

}
