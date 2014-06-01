using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	static GameManager instance;

	static Vector3 worldMapPlayerPosition = new Vector3();

	void Awake()
	{
		if (instance)
		{
			Destroy(gameObject);
			return;
		}
		instance = this;    
		DontDestroyOnLoad(this); 
	}
	
	void Start(){

	}
	
	void OnLevelWasLoaded(int n){
		if (Application.loadedLevelName=="WorldMap" && worldMapPlayerPosition != new Vector3()){
			GameObject.FindGameObjectWithTag("Player").transform.position=worldMapPlayerPosition;
		}
	}

	//this way, from other scripts, you can call GameManager.setWorldPlayerPosition(something) instead of having to find the gameobject with the script
	public static void setWorldPlayerPosition(Vector3 pos){
		//Debug.Log(pos);
		if (Application.loadedLevelName=="WorldMap")
			worldMapPlayerPosition=pos;
	}
	
}
