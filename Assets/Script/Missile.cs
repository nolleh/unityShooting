using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * Time.deltaTime * 3f);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("missile colide");
		Destroy(col.gameObject);
	}
}
