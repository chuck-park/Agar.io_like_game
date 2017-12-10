using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassController : MonoBehaviour {

	public int initMass = 25;
	public int prevMass = 0;
	public int mass = 25;
	public int pickupMass = 1;

	public int totalMass;
	public int prevTotalMass;

	// Use this for initialization
	void Start () {
		totalMass = initMass;
		prevTotalMass = totalMass;
	}

	public void IncreaseMass(int mass) {
		prevTotalMass = totalMass;
		totalMass = totalMass + mass;
		Debug.Log ("IncreaseMass: " + mass);
	}

	public void DecreaseMass(int mass) {
		prevTotalMass = totalMass;
		totalMass = totalMass - mass;
		Debug.Log ("DecreaseMass: " + mass);
	}
}
