using UnityEngine;
using System.Collections;

public class Panier : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<MeshRenderer>().enabled = false;
			}

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Poule(5)")
			Debug.Log ("Win !!");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
