using UnityEngine;
using System.Collections;
using System;

public class controller : MonoBehaviour {
	public int speed = 1;
	DateTime lastShoot;
	void Awake () {

	}
	// Use this for initialization
	void Start () {
		lastShoot = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
		move();	
	}

	void move () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			//transform.localPosition = new Vector3(
			//	transform.localPosition.x, 
			//	transform.localPosition.y + 0.1f, 
			//	transform.localPosition.z);
			transform.Translate(Vector3.up * Time.deltaTime * speed);
		}
		else if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(Vector3.down * Time.deltaTime * speed);
		}
		else if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(Vector3.left * Time.deltaTime * speed);
		}
		else if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(Vector3.right * Time.deltaTime * speed);
		}
		else if (Input.GetKey(KeyCode.Space) && 
			((DateTime.Now - lastShoot).Milliseconds > 50))  {
			GameObject miss = Resources.Load("Missile") as GameObject;
		  // clone
			Instantiate(miss, new Vector2(transform.localPosition.x + 2f, 
				transform.localPosition.y), Quaternion.identity);
			lastShoot = DateTime.Now;
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		Destroy(col.gameObject);
	}
	void OnTriggerEnter2D(Collider2D collision)
	{
		var mineAudio = transform.GetComponent<AudioSource>();
		mineAudio.Play();
		Destroy(collision.gameObject);
	}
}
