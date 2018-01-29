using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float jumpHeight;
    public float moveSpeed;

    public Transform groundCheck,groundCheck1;
    public float offset;
    public LayerMask whatIsGround;
    private bool grounded;
    private bool doubleJumped;
    private float groundx;

    GameObject cube;
    Rigidbody2D player;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update () {
        grounded = Physics2D.OverlapArea(groundCheck.position,groundCheck1.position,whatIsGround);
        groundx = groundCheck.position.x;
        if (grounded)
            doubleJumped = false;

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
            Jump();

        if (Input.GetKeyDown(KeyCode.Space) && !grounded && !doubleJumped)
        {
            Jump();
            doubleJumped = true;
            groundx -= offset;
            //groundCheck.position.x = groundx;

        }

        if (Input.GetKey(KeyCode.LeftArrow))
            player.velocity = new Vector2(-moveSpeed, player.velocity.y);
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
            player.velocity = new Vector2(-3f, player.velocity.y);

        if (Input.GetKey(KeyCode.RightArrow))
            player.velocity = new Vector2(moveSpeed, player.velocity.y);
        else if (Input.GetKeyUp(KeyCode.RightArrow))
            player.velocity = new Vector2(3f, player.velocity.y);

    }

   void Jump()
    {
        player.velocity = new Vector2(player.velocity.x, jumpHeight);
    }
    
}
