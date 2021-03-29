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

public delegate void onInvoke();
[Serializable]
public class Skill
{
    public string name;
    public string type;
    public onInvoke onInvoke;
    
}
 
public class Skills : MonoBehaviour
{
    public Skill[] skillSlots;
    public Skill[] knownSkills;

    public void Start()
    {
        Skill attack = new Skill();
        skillSlots = new Skill[4];

        attack.name = "Swing";
        attack.type = "PAS";
        attack.onInvoke += Swing;

        slotSkill(attack, "Primary");
    }
    
    public void slotSkill(Skill skill, string slot)
    {
        int slotNum =0;
        switch (slot)
        {
            case "Primary":
                slotNum = 0;
                break;
            case "Seconday":
                slotNum = 1;
                break;
            case "Support":
                slotNum = 2;
                break;
            case "Movement":
                slotNum = 3;
                break;
        }
        skillSlots[slotNum] = skill;
    }

    

    private void Update()
    {
        
    }
    public void Swing()
    {
        Debug.Log("swooosh");
    }
}
