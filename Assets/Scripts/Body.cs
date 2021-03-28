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
    // Start is called before the first frame update
    public GameObject worldObj;
    [SerializeField] public StatBlock statsBlock;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Combat combatD = (Combat)worldObj.GetComponent(typeof(Combat));
        
       // combatD.InitiateCombat(this.gameObject, col.gameObject);

    }
}
