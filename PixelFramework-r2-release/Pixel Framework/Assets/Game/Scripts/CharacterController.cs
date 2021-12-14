using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Rigidbody rigidbody;
    private Animator animator;
    private float jumpForce = 50f;

    private bool isDead = false;
    private bool isMovement;

    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Move();
    }

    private void Move()
    {
        if (!isDead && isMovement)
        {
            rigidbody.position += Vector3.forward * speed;
            animator.SetBool("IsRunning", true);
        }
    }

    public void Play()
    {
        MakeMove();
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void MakeMove()
    {
        isMovement = true;
    }
}
