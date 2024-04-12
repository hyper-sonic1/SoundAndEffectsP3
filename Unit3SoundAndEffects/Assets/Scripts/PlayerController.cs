using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
   
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }
    public bool isOnGround = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
            isOnGround = false;

            private void OnCollisionEnter(Collision collision)
            {
                isOnGround = true;
            }
        }
    }
}
