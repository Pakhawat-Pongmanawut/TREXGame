using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController player;
    private Vector3 direction;

    public float gravity = 9.81f * 2f;
    public float jumpForce = 8f;

    private void Awake()
    {
        player = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        direction = Vector3.zero;
    }

    private void Update()
    {
        direction += Vector3.down * gravity * Time.deltaTime;
        if(player.isGrounded)
        {
            direction = Vector3.down;

            if(Input.GetKey(KeyCode.Space))
            {
                direction = Vector3.up * jumpForce;
            }
        }

        player.Move(direction*Time.deltaTime);
    }
}
