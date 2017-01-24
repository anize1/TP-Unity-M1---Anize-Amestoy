using UnityEngine;
using System.Collections;

public class TestCours : MonoBehaviour {
	Transform t;
	public Vector3 deplacement = new Vector3(0.01f, 0, 0);

	// Use this for initialization
	void Start () {
		t = GetComponent<Transform>();
		if (t == null) Debug.Log ("Pas de transform !!");
	}
	
	// Update is called once per frame
	void Update () {
		{
			t.position = t.position + deplacement;
		}
	}
}
