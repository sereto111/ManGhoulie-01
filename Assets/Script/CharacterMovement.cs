
using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	// Use this for initialization
		

	public float maxSpeed = 6.0f;
	public bool facingRight = true;
	public float moveDirection;
	private Rigidbody rigidbody;

	public float jumpSpeed = 600.0f;

	public bool grounded = false;
	public Transform groundCheck;
	public float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent <Rigidbody> ();
		groundCheck = GameObject.Find("GroundCheck").transform;
	}
	
	// Update is called once per frame

    
	void Update () {
		moveDirection = Input.GetAxis ("Horizontal");

		if(grounded && Input.GetButtonDown("Jump"))
		{
			rigidbody.AddForce(new Vector2(0, jumpSpeed));
		}
	}

	void FixedUpdate () {
		rigidbody.velocity = new Vector2 (moveDirection * maxSpeed, rigidbody.velocity.y);
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		if (moveDirection > 0.0f && !facingRight) {
			Flip ();
		} else if (moveDirection < 0.0f && facingRight) {
			Flip ();
		}

	}
    
	void Flip() {
		facingRight = !facingRight;
		transform.Rotate (Vector3.up, 180.0f, Space.World);
	}

}
