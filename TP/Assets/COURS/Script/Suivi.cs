using UnityEngine;
using System.Collections;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class Suivi : MonoBehaviour {

	UnityEngine.AI.NavMeshAgent na;
	GameObject player;
	float timerPathPlanning = 0;


	// Use this for initialization
	void Start () {
		na = GetComponent<UnityEngine.AI.NavMeshAgent>();
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		timerPathPlanning += Time.deltaTime;
		if(timerPathPlanning > 0.3f)
		{
			na.SetDestination (player.transform.position);
	  		timerPathPlanning = 0.0f;
	}
}
}