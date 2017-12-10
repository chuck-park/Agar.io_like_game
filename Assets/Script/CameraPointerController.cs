using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPointerController : MonoBehaviour
{
	public int initMass = 25;
	public int prevMass;
	public int mass = 25;

	public Transform followingTarget;
	private float followingSpeed = 30.0f;
	private float boundary; // boundary for preventing to overlap

	// Use this for initialization
	// all of the Start() is called on the first frame that the script is active
	void Start ()
	{
		boundary = transform.localScale.x * 3;
	}

	// Update() is called once per frame
	// and it is called before rendering a frame
	void Update ()
	{
		if ((transform.position - followingTarget.position).magnitude > boundary) { // prevent shittering
			transform.LookAt (followingTarget.position);
			transform.Translate (0.0f, 0.0f, followingSpeed * Time.deltaTime);
		}

		followingSpeed = 30.0f * ((float)initMass / (float)mass); // the bigger, the slower 
	}
}