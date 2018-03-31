using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class SlimeMover : MonoBehaviour {

	NavMeshAgent agent;
	public Transform food;
	public float speed1;
	public float speed2;

	void Start ()
	{
		agent = this.GetComponent<NavMeshAgent> ();
		agent.speed = Random.Range (speed1 * 1.0f, speed2 * 1.0f);
	}

	void Update ()
	{
		agent.SetDestination (food.position);
		if (agent.destination == (food.position))
			Destroy (food);
	
		}
}