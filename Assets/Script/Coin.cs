using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// left -> right Coin
		transform.Translate(Vector3.left * Time.deltaTime * 3f);

		if (transform.localPosition.x < -10f)
		{
			Destroy(this.gameObject);
		}
	}
}
