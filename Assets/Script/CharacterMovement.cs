using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	public bool facingRight = true;
	public float moveDirection;
	
	
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
    
	void Update () {
		moveDirection = Input.GetAxis ("Horizontal");

		
	}

	void FixedUpdate () {
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
