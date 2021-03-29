using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{
    public Controls controls;
    public Body playerStats;
    public Skills playerSkills;
    Vector2 playerPos;
    Rigidbody2D rigidbody2d;
    public bool isMoving;
    private Vector2 movementInput = Vector2.zero;

    private void Awake()
    {
        controls = new Controls();
    }

 
    void Start()
    {
    
        playerStats = GetComponent<Body>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        playerSkills = GetComponent<Skills>();
    }

    private void FixedUpdate()
    {
        doMove();
    }

    private void doMove()
    {
        playerPos += movementInput * playerStats.statsBlock.speed * Time.deltaTime;
        rigidbody2d.MovePosition(playerPos);
    }

    public void handlePrimaryActiveSkillUse(InputAction.CallbackContext obj)
    {
        Debug.Log("PAS used");
        playerSkills.skillSlots[0].onInvoke();
    }

    public void handleMove(InputAction.CallbackContext obj)
    {
        playerPos = rigidbody2d.position;
        movementInput = obj.ReadValue<Vector2>();
    }
    public void handleRHand(InputAction.CallbackContext obj)
    {

    }
    public void handleLHand(InputAction.CallbackContext obj)
    {

    }

}

