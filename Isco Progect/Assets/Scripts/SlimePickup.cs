using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimePickup : MonoBehaviour {
	Vector3 dist;
	float posX;
	float posY;

	// Use this for initialization
	void OnMouseDown() {
		dist = Camera.main.WorldToScreenPoint (transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;

		
	}
	
	// Update is called once per frame
	void OnMouseDrag () {
		Vector3 curPos = new Vector3 (Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
			transform.position = worldPos;
		
	}
}
