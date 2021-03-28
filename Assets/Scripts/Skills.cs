using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//so this will hold, i guess, the architechture for skills/abilities
//skill slots into 
//  PrimaryActive
//  SecondaryActive
//  Movement
//  Support
//  Passive

//combat controls
// LT defend/block/parry
// RT Attack w/ Equiped Weapon
// LB SUpport skill
// RB Movement Skill
// A  Primary Active
//  X   Secondary Active
// Y Menu?
// B ?
// Left and Right, page through left/right
// up / down duh page through what tho? quick menu?
[Serializable]
public class Skill
{
    public string name;
    public string type;
    
}
 
public class Skills : MonoBehaviour
{
    public Skill[] skillSlots;

    public void Start()
    {
        Skill attack = new Skill();
        skillSlots = new Skill[4];

        attack.name = "Swing";
        attack.type = "PAS";
        

        skillSlots[0] = attack;
    }
    

    

    private void Update()
    {
        
    }
    public void Swing()
    {
        Debug.Log("swooosh");
    }
}
