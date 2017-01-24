using UnityEngine;
using System.Collections;

public class BouleTombe : MonoBehaviour {
	public Rigidbody useGravity;

	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			GetComponent<Rigidbody> ().useGravity = true;
		}
	}
}