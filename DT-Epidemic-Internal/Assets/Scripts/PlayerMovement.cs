using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;

    Rigidbody2D rb2d;

    SpriteRenderer spriteRenderer;

    [SerializeField]
    public bool isGrounded;

    [SerializeField]
    float raycastLength = 0.05f;

    [SerializeField]
    Transform groundCheck;

    [SerializeField]
    Transform groundCheckR;

    [SerializeField]
    Transform groundCheckL;

    [SerializeField]
    private float runSpeed = 2f;

    [SerializeField]
    private float jumpSpeed = 4f;


    // use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        

    }

    void Update()
    {
        //if()
    }

    //Fixed Update is more efficient when using physics than using normal Update.
    private void FixedUpdate()
    {
        //I was originally using a linecast but decided it would be easier to use a raycast instead as I unerstood this better.

        //if ((Physics2D.Linecast(transform.position, groundcheck.position, 1 << LayerMask.NameToLayer(""))) ||
        //        (Physics2D.Linecast(transform.position, groundcheckR.position, 1 << LayerMask.NameToLayer("Ground"))) ||
        //        (Physics2D.Linecast(transform.position, groundcheckL.position, 1 << LayerMask.NameToLayer("Ground"))))
        if (PlayerIsOnGround())
        {

           //Debug.Log("on the ground");
           isGrounded = true;
        }

        else
        {
            //Debug.Log("in the air");
            isGrounded = false;
            animator.Play("Player_jump");
        }

        //Takes the player input and moves the player in that idrection and plays the run animation
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);

            if (isGrounded)
                animator.Play("Player_run");

            //Flips the sprite on the x axis (sprite is facing in the opposite direction)
            spriteRenderer.flipX = false;

        }

        //Takes the player input and moves the player in that idrection and plays the run animation
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);

            if (isGrounded)
                animator.Play("Player_run");

            //Flips the sprite on the x axis (sprite is facing in the opposite direction)
            spriteRenderer.flipX = true;
        }

        //If the player is not moving the character then it will play the idle animation
        else
        {
            if (isGrounded)
                animator.Play("Player_idle");

            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

        //Takes the player input, makes the player jump and plays the jump animation
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            animator.Play("Player_jump");
        }



    }
    // Detecting whether player hits the ground to re enable ability to jump (using raycasts)
    public bool PlayerIsOnGround()
    {
        bool groundCheck1 = Physics2D.Raycast(groundCheck.position, -Vector2.up, raycastLength, LayerMask.GetMask("Ground"));
        //Debug.DrawRay(groundCheck.position, -Vector2.up);
        bool groundCheck2 = Physics2D.Raycast(groundCheckL.position, -Vector2.up, raycastLength, LayerMask.GetMask("Ground"));
        bool groundCheck3 = Physics2D.Raycast(groundCheckR.position, -Vector2.up, raycastLength, LayerMask.GetMask("Ground"));
        if (groundCheck1 || groundCheck2 || groundCheck3)
        {
            return true;
        }
        return false;
    }


}
