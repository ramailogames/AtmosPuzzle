using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    Rigidbody2D rb;
    Animator anim;

    [Header("Movements")]
    public float speed;
    private float horizontalInput;
    private float verticalInput;
    bool isFacingRight = true;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        Movement();
    }


    void Movement()
    {
        rb.velocity = new Vector2(horizontalInput, verticalInput).normalized * speed * Time.deltaTime;
        anim.SetFloat("speed", Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
        if (isFacingRight && horizontalInput < 0)
        {
            Flip();
        }
        else if (!isFacingRight && horizontalInput > 0)
        {
            Flip();
        }
    }


    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180.0f, 0f);
    }

    public void Feet()
    {
        int rand = Random.Range(1, 3);
        AudioManagerCS.instance.PlayOneShot("footstep" + rand);
    }

    
}
