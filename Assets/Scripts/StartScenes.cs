using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScenes : MonoBehaviour {
	public Button begin;
	public string nextScenes;
	// Use this for initialization
	void Start () {
		begin.onClick.AddListener (StartGames);
	}
	public void StartGames(){
		SceneManager.LoadScene (nextScenes);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
