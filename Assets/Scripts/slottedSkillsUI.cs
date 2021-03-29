using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slottedSkillsUI : MonoBehaviour
{

    public Text primarySlot;
    public GameObject player;

    void Start()
    {
        
    }

   
    void Update()
    {
        Skill pas;
        pas = player.GetComponent<Skills>().skillSlots[0];

        primarySlot.text = pas.name;
    }
}
