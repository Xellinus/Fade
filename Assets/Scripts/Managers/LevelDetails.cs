using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDetails : MonoBehaviour
{
    // Start is called before the first frame update
    public bool inCombat;
    public bool paused;
    public enum GameStates { Field, Skills, Inventory, Menu}
    public GameStates gameState;
    public GameObject skillsUI;
    public GameObject inventoryUI;
    public GameObject fieldUI;

    void Start()
    {
        gameState = GameStates.Field;

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
