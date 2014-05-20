using UnityEngine;
using System.Collections;

public class eventTrigger1 : MonoBehaviour {
	public float speed = 15.0f;
	public float maxY = 2.0f;
	public float X = 298.5f;
	public float Z = 25.8f;
	bool move = false;
	Vector3 newpos;
	GameObject Event;
	
	// Use this for initialization
	void Start () {
		newpos = new Vector3(X,maxY,Z);
		Event = GameObject.Find ("event2");
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
