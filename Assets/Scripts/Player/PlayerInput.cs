using System;
using System.Collections;
using System.Collections.Generic;
using U_Puzel;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    #region Input Init

    public InputManager inputs;
    private void Awake()
    {
        inputs = new InputManager();
    }
    private void OnEnable()
    {
        inputs.Enable();
    }
    private void OnDisable()
    {
        inputs.Disable();
    }

    #endregion

    private void Update()
    {
        GetInput();
    }

    [Range(.1f, 36f)]
    public float playerSpeed = 9f;
    [Range(.1f, 36f)]
    public float jumpForce = 9f;

    public Transform groundPoint;

    [Range(0.1f, 1.8f)]
    public float groundDist = .27f;
    public LayerMask ground;

    public void GetInput()
    {
        Debug.Log("Getting Input!");

        IPlayerMove player = GetComponent<IPlayerMove>();

        player.Move(GetMovement(), playerSpeed);

        if (Physics2D.OverlapCircle(groundPoint.position, groundDist, ground)) 
        { 
            if (inputs.player.Jump.triggered)
            {
                player.Jump(jumpForce);
            }
        }
    }

    public Vector3 GetMovement()
    {
        Vector3 move = new Vector3();

        move.x = inputs.player.Movement.ReadValue<float>();

        return move;
    }
}
