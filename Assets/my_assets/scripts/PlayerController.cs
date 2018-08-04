using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 lastCheckpoint;
    public Animator playerAnim;
    public CharacterController playerController;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        lastCheckpoint = transform.position;
        playerController = GetComponent<CharacterController>();
        playerAnim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseInput = Input.GetAxis("Mouse X");
        Vector3 lookhere = new Vector3(0, mouseInput, 0);
        transform.Rotate(lookhere);

        if (playerController.isGrounded)
        {
            playerAnim.SetBool("isJumping", false);
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (moveDirection != Vector3.zero)
            {
                playerAnim.SetBool("isRunning", true);
            }
            else
            {
                playerAnim.SetBool("isRunning", false);
            }

            if (Input.GetButton("Jump"))
            {
                playerAnim.SetBool("isRunning", false);
                playerAnim.SetBool("isJumping", true);
                moveDirection.y = jumpSpeed;

            }

        }
        else
        {
            playerAnim.SetBool("isRunning", false);
        }
        moveDirection.y -= gravity * Time.deltaTime;
        playerController.Move(moveDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "lava")
        {
            transform.position = lastCheckpoint;
        }
    }
}