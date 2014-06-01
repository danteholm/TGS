using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//here we save the current instance of the GameManager gameobject
	static GameManager instance;

	static Vector3 worldMapPlayerPosition = new Vector3();

	void Awake()
	{
		//if there is already an instance because we have loaded a scene with another GameManager we destroy the new one and keep the initial one
		if (instance)
		{
			Destroy(gameObject);
			return;
		}
		//otherwise we set instance and make the gameobject not destroyable by loading scenes
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
