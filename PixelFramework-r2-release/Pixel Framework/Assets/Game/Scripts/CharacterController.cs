using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Rigidbody rigidbody;
    private Animator animator;
    private float jumpForce = 30f;

    private bool isDead;
    private bool isWon;
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
        if ((!isDead || !isWon) && isMovement)
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

    public void MakeLose()
    {
        isDead = true;
    }

    public void MakeWin()
    {
        isWon = true;
    }

    public bool IsDead()
    {
        return isDead;
    }

    public bool IsWon()
    {
        return isWon;
    }
}
