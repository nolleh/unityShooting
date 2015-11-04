using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * Time.deltaTime * 3f);
		if (transform.localPosition.x > 10f)
			Destroy(this.gameObject);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		Destroy(col.gameObject);
		Destroy(this.gameObject);
	}
}
