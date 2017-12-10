using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject pointer;
    public GameObject massController;
	private MassController massControllerInstance;

    private Vector3 offset;

	float prevTotalMass;
	float totalMass;

	// Use this for initialization
	void Start () {
		massControllerInstance = massController.GetComponent<MassController> ();

		offset = transform.position - pointer.transform.position;

		prevTotalMass = (float)massControllerInstance.prevTotalMass;
	}

	void Update () {
		
		totalMass = (float)massControllerInstance.totalMass;

		// camera get higher when you eat 5 pickups
		if(totalMass > prevTotalMass + 4)
		{
			Debug.Log ("Camera higher");
			offset.y = offset.y + (totalMass * 0.1f);
			prevTotalMass = totalMass;
		}
	}
	
	// LateUpdate() runs every frame like update()
    // but it is guaranteed to run after all items have been processed
	void LateUpdate () {
		//Debug.Log ("mass: " + mass);
        transform.position = pointer.transform.position + offset;
		//Debug.Log ("transform.position.y: " + transform.position.y);
	}
}
