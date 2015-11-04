using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	public int speed = 1;

	void Awake () {

	}
	// Use this for initialization
	void Start () {
	
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
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("collide");
		Destroy(col.gameObject);
	}
	void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("trigeer!!!!!!!!");
		var mineAudio = transform.GetComponent<AudioSource>();
		mineAudio.Play();
		Destroy(collision.gameObject);
	}
}
