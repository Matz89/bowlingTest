using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public Vector3 launchVelocity;

	private AudioSource audioSource;
	private Rigidbody rigidb;

	// Use this for initialization
	void Start () {

		rigidb = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();

		Launch ();
	}

	public void Launch ()
	{
		rigidb.velocity = launchVelocity;
		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
