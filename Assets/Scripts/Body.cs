using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class StatBlock
{
    public float speed;
    public float hp;
    public float power;
    public float mana;

}
public class Body : MonoBehaviour
{

    public GameObject worldObj;
    [SerializeField] public StatBlock statsBlock;


    public void Start()
    {
        TickManager.onTick += handleHealth;
    }

    private void handleHealth(object sender, TickManager.OnTickEventArgs e)
    {
        //heat beat. Manage everything in here like bleeding and checking for death.
        if(statsBlock.hp <=0)
        {
            //Die, duh.
        }
    }

    public void receiveDamage(float dmg)
    {
        statsBlock.hp -= dmg;

    }
    private void Update()
    {
        
    }

    

    void OnTriggerEnter2D(Collider2D col)
    {
        //Combat combatD = (Combat)worldObj.GetComponent(typeof(Combat));
        
       // combatD.InitiateCombat(this.gameObject, col.gameObject);

    }
}
