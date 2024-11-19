using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	public float maxSpeed = 6.0f;
	public bool facingRight = true;
	public float moveDirection;
	private Rigidbody rigidbody;
	
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent <Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		moveDirection = Input.GetAxis ("Horizontal");

	}
	void FixedUpdate () {
		rigidbody.velocity = new Vector2 (moveDirection * maxSpeed, rigidbody.velocity.y);
	}
}
