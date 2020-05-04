using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelOnCollision : MonoBehaviour {
	[SerializeField]
	string stringTag;

	[SerializeField]
	string stringScene;

	private void OnCollisionEnter (Collision collision)
	{
		if (collision.collider.tag == stringTag) {
			SceneManager.LoadScene (stringScene);
		}

	}
}
