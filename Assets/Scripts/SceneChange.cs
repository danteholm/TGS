using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {
	public string lvl;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player")) {
			GameManager.setWorldPlayerPosition(other.transform.position);
			Application.LoadLevel (lvl);
		}
	}

}
