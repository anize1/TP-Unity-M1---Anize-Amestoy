using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public Transform grenadePrefab;
	Transform gren = null;
	float timeThrow = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(gren)
			gren.position = Camera.main.transform.position +
				Camera.main.transform.forward;

		if (Input.GetButton("Fire1"))
		{
			timeThrow += Time.deltaTime;

			if (gren == null)
			{
				timeThrow = 0;
				gren = Instantiate(grenadePrefab,
					Camera.main.transform.position +
					Camera.main.transform.forward,
					Quaternion.identity) as Transform;
			}

		}
		else
		{
			if (gren != null)
			{
				Vector3 force = Camera.main.transform.forward;
				force = Quaternion.AngleAxis(-30, Camera.main.transform.right) * force;
				force = force.normalized * 10 * timeThrow;
				Rigidbody rbGren = gren.GetComponent<Rigidbody>();
				rbGren.velocity = force;
				gren = null;
			}
		}
	}
}
