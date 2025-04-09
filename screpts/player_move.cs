using NUnit.Framework;
using UnityEngine;

public class player_move : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D box ;
    private Animator an;
    private SpriteRenderer sp;
    float dirX;
    public float speed = 7f;
    public float forceJump = 14f;
    private enum moveState { idle, run, jump, fall }
    public AudioSource Jump ;
    public LayerMask jumpOnce ;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(dirX * speed, rb.linearVelocity.y);

        
        if (Input.GetButtonDown("Jump") && isGround())
        {
            Jump.Play ();
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forceJump);
        }

        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        moveState state;

        if (dirX > 0)
        {
            state = moveState.run;
            sp.flipX = false;
        }
        else if (dirX < 0)
        {
            state = moveState.run;
            sp.flipX = true;
        }
        else
        {
            state = moveState.idle;
        }

        if (rb.linearVelocity.y > 0.1f)
        {
            state = moveState.jump;
        }
        else if (rb.linearVelocity.y < -0.1f)
        {
            state = moveState.fall;
        }

        an.SetInteger("state", (int)state);
    }
    private bool isGround (){
        return Physics2D.BoxCast(box.bounds.center , box.bounds.size,0f,Vector2.down,.1f,jumpOnce);
        

    }
}
