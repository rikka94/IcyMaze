﻿using UnityEngine;
using System.Collections;

public class GameObjectScript : MonoBehaviour {
	public GameObject fireBox;
	float timeElapsed = 0f;
	float[] X = {-3f,-5f,-8f,-8f,-10f,-12f, -14f,-14f, -17f, -20f, -23f, -27, -27f,-27f};
	float[] Z = {-7f, -3.3f, 0.5f,-3.3f,-7f,0.5f,-3.3f,-7f, 0.5f, -3.3f, -7f , 0.5f , -3.3f , -7f};
	int loop = 0;
	bool test = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (test) {
			timeElapsed += Time.deltaTime;
			if (timeElapsed >= 1f) {
				GameObject appear = (GameObject)Instantiate (fireBox, new Vector3 (X[loop], 10f, Z[loop]), Quaternion.identity);
				timeElapsed = 0f;
				loop++;
			}
			if(loop>12){
				test = false;
			}
		} else {
		}
	}

	void OnGUI()
	{
		{
			GUI.Box(new Rect(Screen.width/2 + 350, Screen.height/2 - 300, 250, 90),
			        "Use 'ASDW' keys to move.\nGoal is to reach the end.\nAvoid flame box and flame ball.\nBeware of trap");		
		}
	}
}