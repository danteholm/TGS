using UnityEngine;
using System.Collections;

public class camFollow : MonoBehaviour {
	public Transform target;
	public float y = 7.0f;
	public float z = 20.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = target.transform.position + new Vector3 (0, y, z);
	}
}
