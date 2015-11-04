using UnityEngine;
using System.Collections;

public class StartClick : MonoBehaviour {

	public void ClickGameStartBtn()
	{
		Debug.Log("GameStart!");
		Application.LoadLevel("Game01");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
