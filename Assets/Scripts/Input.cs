using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public Controls controls;
    public Body playerStats;
    public Skills playerSkills;
    public Vector2 playerPos;
    Rigidbody2D rigidbody2d;
    public bool isMoving;
    private Vector2 movementInput = Vector2.zero;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;
    [SerializeField] private float walkAnimThreshold;

    private void Awake()
    {
        controls = new Controls();
    }

    void Start()
    {
        playerStats = GetComponent<Body>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        playerSkills = GetComponent<Skills>();
        playerPos = rigidbody2d.position;
    }

    private void FixedUpdate()
    {
        doMove();
    }

    private void doMove()
    {
        playerPos += movementInput * playerStats.statsBlock.speed * Time.deltaTime;
        rigidbody2d.MovePosition(playerPos);

        bool isWalking = movementInput.magnitude > walkAnimThreshold;

        // Setting false causes transition to idle orientation pose for the direction of last movement.
        animator.SetBool("isWalking", isWalking);

        if (isWalking)
        {
            // calculate facing from input direction
            if (movementInput.x >= movementInput.y)
            {
                if (Mathf.Abs(movementInput.y) < movementInput.x)
                {
                    // right
                    animator.Play("Base Layer.WalkSide");
                    spriteRenderer.flipX = false;
                }
                else
                {
                    // down
                    animator.Play("Base Layer.WalkDown");
                    spriteRenderer.flipX = false;
                }
            }
            else
            {
                if (movementInput.y < Mathf.Abs(movementInput.x))
                {
                    // left
                    animator.Play("Base Layer.WalkSide");
                    spriteRenderer.flipX = true;
                }
                else
                {
                    // up
                    animator.Play("Base Layer.WalkUp");
                    spriteRenderer.flipX = false;
                }
            }
        }
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

