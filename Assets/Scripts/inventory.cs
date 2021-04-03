using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public IDictionary<Item, int> inventory = new Dictionary<Item, int>();

    public void AddItem(Item item, int count)
    {
        if (count == 0)
            count = 1;

        inventory.Add(item, count);

    }
    public void SubItem(string name, int count)
    {
        Item thing = GetItemByName(name);
        if (count == 0)
            count = 1;
        if(thing != null)
            inventory[thing] -= count;
    }

    public void RemoveItembyName(string name)
    {
        inventory.Remove(GetItemByName(name));
    }
    public Item GetItemByName(string name)
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
