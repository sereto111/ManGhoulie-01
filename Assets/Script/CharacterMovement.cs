
using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	// Use this for initialization
		

	public float maxSpeed = 6.0f;
	public bool facingRight = true;
	public float moveDirection;
	private Rigidbody rigidbody;
	private Animator anim;
	
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent <Rigidbody> ();
		anim = GetComponent <Animator> ();
	
	}
	
	// Update is called once per frame

    
	void Update () {
		moveDirection = Input.GetAxis ("Horizontal");		
	}

	void FixedUpdate () {
		rigidbody.velocity = new Vector2 (moveDirection * maxSpeed, rigidbody.velocity.y);
		if (moveDirection > 0.0f && !facingRight) {
			Flip ();
		} else if (moveDirection < 0.0f && facingRight) {
			Flip ();
		}
		anim.SetFloat("Speed", Mathf.Abs(moveDirection));

	}
    
	void Flip() {
		facingRight = !facingRight;
		transform.Rotate (Vector3.up, 180.0f, Space.World);
	}

}
