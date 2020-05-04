using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateTowards : MonoBehaviour {
	[SerializeField]
	Transform transformTowards;

	[SerializeField]
	float fSpeed;

	Rigidbody rigid;

	// Start is called before the first frame update
	void Start ()
	{
		rigid = GetComponent<Rigidbody> ();

		if (transformTowards == null) {
			transformTowards = FindObjectOfType<AddPlayerControlledVelocity> ().transform;
		}
	}

	// Update is called once per frame
	void Update ()
	{
		rigid.velocity += (transformTowards.position - transform.position).normalized * fSpeed * Time.deltaTime;
	}
}
