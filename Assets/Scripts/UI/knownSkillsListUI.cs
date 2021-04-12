using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knownSkillsListUI : MonoBehaviour
{
    GameObject player;
    public Transform skillUI;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Skill x in player.GetComponent<Skills>().knownSkills)
        {
            Transform knownSkill;
            knownSkill = GameObject.Instantiate(skillUI);
            knownSkill.GetComponent<knownSkillsUI>().skill = x;
            knownSkill.SetParent(this.transform);
            
        }
    }
}
