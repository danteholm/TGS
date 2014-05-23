using UnityEngine;
using System.Collections;

public class eventTrigger : MonoBehaviour {
	public float speed = 15.0f;
	public float maxY = 2.0f;
	//public float X = 218;
	//public float Z = -220;
	bool move = false;
	Vector3 newpos;
	public GameObject Event;

	// Use this for initialization
	void Start () {
		newpos = new Vector3(Event.transform.position.x,maxY,Event.transform.position.z);

	}

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player"))
			move = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (move) {
			Event.transform.position = Vector3.MoveTowards (Event.transform.position, newpos, Time.deltaTime * speed);
			if (Vector3.Distance (Event.transform.position, newpos) < 0.1f) {
				move = false;
			}
		}
	}
}
