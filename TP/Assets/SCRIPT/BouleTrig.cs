using UnityEngine;
using System.Collections;

public class BouleTrig : MonoBehaviour {

	public Transform [] boules;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider col){
		foreach(Transform b in boules)
			b.GetComponent<Rigidbody>().useGravity = true;
	
	
	}
}
