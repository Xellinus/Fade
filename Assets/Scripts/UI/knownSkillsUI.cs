using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class knownSkillsUI : MonoBehaviour
{
    public Text text;
    public Skill skill;
    // Start is called before the first frame update
    void Start()
    {
        skill = new Skill();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = skill.name;
    }
}
