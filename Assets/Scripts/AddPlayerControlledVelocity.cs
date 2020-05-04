using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour {

	[SerializeField]
	KeyCode keyPositive;

	[SerializeField]
	KeyCode keyNegative;

	[SerializeField]
	Vector3 v3Force;


	private bool? setKeyMarker (KeyCode keycode)
	{

		if (Input.GetKeyDown (keycode)) {
			return true;
		}

		if (Input.GetKeyUp (keycode)) {
			return false;
		}

		return null;
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		if (Input.GetKey (keyPositive)) {
			rigidbody.velocity += v3Force;
		}

		if (Input.GetKey (keyNegative)) {
			rigidbody.velocity -= v3Force;
		}

	}

}
