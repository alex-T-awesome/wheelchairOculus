using UnityEngine;
using System.Collections;

public class NewControlScript : MonoBehaviour {
	
	public float forwardSpeed = 3.0f;
	public float turnSpeed = 2.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float forwardMoveAmount = 0.0f;//actual amount we will move this frame
		forwardMoveAmount = Input.GetAxis("Vertical") * this.forwardSpeed;
		
		float turnAmount = 0.0f;//actual amount we will turn this frame
		turnAmount = Input.GetAxis("Horizontal") * this.turnSpeed;
		
		this.transform.Rotate(0,turnAmount,0);
		this.GetComponent<Rigidbody>().AddRelativeForce(-forwardMoveAmount,0,0);
	}
}
