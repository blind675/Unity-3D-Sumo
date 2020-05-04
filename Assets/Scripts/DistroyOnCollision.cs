using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyOnCollision : MonoBehaviour {
	[SerializeField]
	string stringTag;

	[SerializeField]
	bool bDestroySelf = false;

	[SerializeField]
	bool bDestroyOther = false;

	private void OnCollisionEnter (Collision collision)
	{
		if (collision.collider.tag == stringTag) {

			if (bDestroyOther) {
				Destroy (collision.gameObject);
			}

			if (bDestroySelf) {
				Destroy (this.gameObject);
			}
		}

	}
}
