using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameControler : MonoBehaviour {
	public Text hintText;
	public InputField inputfield;
	public Text levelText;

	//normal variable
	public string levelAnswer;
	public string levelNumber;
	public string levelHint;
	public string nextScenes;

	//
	void Start(){
		hintText.text = levelHint;

	}
	public void CheckAnswer(){
		if(inputfield.text == levelAnswer){
			hintText.text = "ACCESS SUCCESSFUL";
			hintText.color = Color.green;
			SceneManager.LoadScene (nextScenes);
			
		}else{
			hintText.text = "ACCESS DENIED!!!";
			hintText.color = Color.red;
			inputfield.text = "";
			inputfield.ActivateInputField ();
		}
	}
	//Update is called once per frame
	void Update(){
		
	}
}
