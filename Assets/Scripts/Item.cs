using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public int weight;
    public Sprite inventoryIcon;
    public Sprite fieldIcon;

    private void Awake()
    {
        this.GetComponent<SpriteRenderer>().sprite = fieldIcon;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Pick it up! PICK IT UP! BRUDDDP");
        // collision.GetComponent<Body>().inv.AddItem(this, 1);
        collision.GetComponent<Inventory>().AddItem(this, 1);
        Destroy(gameObject);
        //make like a ska band and PICK IT UP!
    }

}
