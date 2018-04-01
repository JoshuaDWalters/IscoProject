using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class SlimeMover : MonoBehaviour {

	NavMeshAgent agent;
	public Transform food;
	public float speed1;
	public float speed2;

	void Start () {
		agent = this.GetComponent<NavMeshAgent> ();
		agent.speed = Random.Range (speed1 * 1.0f, speed2 * 1.0f);
	}

	void Update () {
		agent.SetDestination (food.position);	
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Food") {
			Debug.Log(other.gameObject.name + " collected!");
			//Do not destroy food here. Add food property here. Food code block will de-activate it once collected.
		}
	}
}