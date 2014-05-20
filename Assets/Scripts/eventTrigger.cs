using UnityEngine;
using System.Collections;

public class eventTrigger : MonoBehaviour {
	public float speed = 15.0f;
	public float maxH = 2.0f;
	bool move = false;
	Vector3 newpos;
	GameObject Event1;

	// Use this for initialization
	void Start () {
		newpos = new Vector3(64,maxH,0);
		Event1 = GameObject.Find ("event1");
	}

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player"))
			//Debug.Log ("its here");
			move = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (move) {
			Event1.transform.position = Vector3.MoveTowards (Event1.transform.position, newpos, Time.deltaTime * speed);
			if (Vector3.Distance (Event1.transform.position, newpos) < 0.1f) {
				move = false;
			}
		}
	}
}
