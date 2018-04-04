using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollecter : MonoBehaviour {

	public GameObject gem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
    
	}
		void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Gem")
			CurrencyCounter.scoreValue += 10;
		Destroy(gem);
	}
}
