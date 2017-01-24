using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
		public bool enter;
		public AudioClip Boule1;
		public AudioClip Boule2;
		private AudioSource source;

	// Use this for initialization
	void Start () {
		enter = false;
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	int count = 1;



	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			enter = true;
			// Play the sound only on the trigger
			if (enter && count == 1) {
				source.PlayOneShot (Boule1);
				source.PlayOneShot (Boule2);
				count = 0;

			}
		}
	}
	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			enter = false;
			count = 1;
		}
	}
}