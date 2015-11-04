using UnityEngine;
using System.Collections;
using System;

public class GameManager : MonoBehaviour {

	DateTime nowTime, heartTime;

	// Use this for initialization
	void Start () {
		nowTime = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
		DateTime checkTime = DateTime.Now;
		
		if ( (checkTime - nowTime).Seconds > 1) 
		{
			nowTime = DateTime.Now;
			MakeCoin();
		}
		if ( (checkTime -heartTime).Seconds > 3)
		{
			heartTime = DateTime.Now;
			MakeHeart();			
		}
	}

	void MakeCoin() {
		float PosY = UnityEngine.Random.Range(-3f, 4f);
		Vector2 randPos = new Vector2(15f, PosY);
		// get Coin object.
		GameObject coin = Resources.Load("Coin") as GameObject;
		//coin.transform.localPosition = randPos;
		// clone
		//Instantiate(coin);

		Instantiate(coin, randPos, Quaternion.identity);
	}

	void MakeHeart() {
		float PosY = UnityEngine.Random.Range(-3f, 4f);
		Vector2 randPos = new Vector2(15f, PosY);
		// get Coin object.
		GameObject coin = Resources.Load("Heart") as GameObject;
		//coin.transform.localPosition = randPos;
		// clone
		//Instantiate(coin);

		Instantiate(coin, randPos, Quaternion.identity);
	}
}
