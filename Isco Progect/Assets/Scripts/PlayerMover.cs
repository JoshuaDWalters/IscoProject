using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

	public float movementSpeed;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (movementSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0, movementSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);
	}
}
