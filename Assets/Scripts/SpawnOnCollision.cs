using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnCollision : MonoBehaviour {
	[SerializeField]
	string stringTag;

	[SerializeField]
	bool bSpawnSelf = false;

	[SerializeField]
	bool bSpawnOther = false;

	[SerializeField]
	GameObject goSpawn;

	private void OnCollisionEnter (Collision collision)
	{
		if (collision.collider.tag == stringTag) {

			if (bSpawnOther) {
				Instantiate (goSpawn, collision.transform.position, Quaternion.identity);
			}

			if (bSpawnSelf) {
				Instantiate (goSpawn, transform.position, Quaternion.identity);
			}
		}

	}
}
