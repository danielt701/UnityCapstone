using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{

    private float Speed;
    private float BoostTimer;
    private bool boosting;
    public Animator animator;

    // speed boost stuff


    private float JumpTimer;
    private bool jumpinghigh;

    // High Jump stuff 



    private float movementInputDirections;

    private int amountOfJumpsLeft;

    private Rigidbody2D rb;

    private bool isFacingRight = true;
    private bool isGrounded;
    private bool canJump;

    public int amountOfJumps = 1;

    public float movementSpeed = 10.0f;
    public float jumpForce = 16.0f;
    public float groundCheckRadius;

    public LayerMask whatIsGround;

    public Transform groundCheck;

    public int CurrHealth;
    public int maxHealth = 100;

    [Header("Events")]
    [Space]

    public UnityEvent StophurtEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    public AudioSource audioSource;
    public AudioClip ClydeJump;
    public AudioClip ClydeBark;
    public AudioClip ClydeWalk;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        amountOfJumpsLeft = amountOfJumps;

        CurrHealth = maxHealth;

        // speed boost timer 
        BoostTimer = 0;
        boosting = false;

        // super jump timer 

        JumpTimer = 0;
        jumpinghigh = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        CheckMovementDirection();
        CheckIfCanJump();

        if (CurrHealth > maxHealth)
        {
            CurrHealth = maxHealth;
        }

        if (CurrHealth <= 0)
        {
            Destroy(gameObject);
        }

        //boost movement 
        if (boosting)
        {
            BoostTimer += Time.deltaTime;
            if (BoostTimer >= 3)
            {
                movementSpeed = 10;
                BoostTimer = 0;
                boosting = false;
            }
        }

        if (jumpinghigh)
        {
            JumpTimer += Time.deltaTime;
            if (JumpTimer >= 4)
            {
                jumpForce = 18.0f;
                JumpTimer = 0;
                jumpinghigh = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SpeedBoost")
        {
            boosting = true;
            movementSpeed = 20;
            Destroy(other.gameObject);
        }

        // Jump Higher boost

        if (other.tag == "SuperJump")
        {

            jumpinghigh = true;
            jumpForce = 30.0f;
            Destroy(other.gameObject);

        }
    }

  



    private void FixedUpdate()
    {
        ApplyMovement();
        CheckSurroundings();
    }

    private void CheckSurroundings()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        animator.SetBool("isJumping", false);

    }

    private void CheckIfCanJump()
    {
        if (isGrounded && rb.velocity.y <= 0)
        {
            amountOfJumpsLeft = amountOfJumps;
        }

        if (amountOfJumpsLeft <= 0)
        {
            canJump = false;
        }
        else
        {
            canJump = true;
        }
    }


    private void CheckInput()
    {
        movementInputDirections = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("speed", Mathf.Abs(movementInputDirections));

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
            animator.SetBool("isJumping", true);
            audioSource.PlayOneShot(ClydeJump, 1.0f);
        }
        

    }

    private void CheckMovementDirection()
    {
        if (isFacingRight && movementInputDirections < 0)
        {
            Flip();
        }
        else if (!isFacingRight && movementInputDirections > 0)
        {
            Flip();
        }

    }

    private void Jump()
    {
        if (canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            amountOfJumpsLeft--;
        }

    }

    private void ApplyMovement()
    {
        rb.velocity = new Vector2(movementSpeed * movementInputDirections, rb.velocity.y);
    }


    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0.0f, 180.0f, 0.0f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }


    public void Damage (int dmg)
    {
        CurrHealth -= dmg;
    }
}

