using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointerController : MonoBehaviour
{
    public float speed;

    // Use this for initialization
    // all of the Start() is called on the first frame that the script is active
    void Start ()
    {

    }
	
	// Update() is called once per frame and it is called before rendering a frame
	void Update ()
    {
		
    }

    // FixedUpdate() is called before performing any physics calculations
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed * moveHorizontal * Time.deltaTime,
            0, speed * moveVertical * Time.deltaTime);
        transform.Translate(movement);
    }
}
