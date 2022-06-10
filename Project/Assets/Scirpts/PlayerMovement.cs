using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

	public Animator animator;
	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	// Update is called once per frame
	void Update () {

		horizontalMove = CrossPlatformInputManager.GetAxis("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (CrossPlatformInputManager.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

		if (CrossPlatformInputManager.GetButtonDown("cruch"))
		{
			crouch = true;
			animator.SetBool("IsCrouching", true);

		}
		else if (CrossPlatformInputManager.GetButtonUp("cruch"))
		{
			crouch = false;
			animator.SetBool("IsCrouching", false);
		}

	}
	public void Onlanding()
    {
		animator.SetBool("IsJumping", false);
    }



	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);

		jump = false;
	}
}
