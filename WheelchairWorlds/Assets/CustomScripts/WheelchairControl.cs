using UnityEngine;
using System.Collections;

public class WheelchairControl : MonoBehaviour {

    public float forwardAcceleration = 120.0f;
    public float turnSpeed = 1.0f;
    public float maxiumSpeed = 2;
    public float joystickHorizontalDeadZone = 0.5f;
	public float joystickVerticalDeadZone = 0f;
	AudioSource audio;

    // Use this for initialization
    void Start()
    {
		audio = GetComponent<AudioSource> ();
    }

    void OnGUI(){
    //    //if (Time.time % 2 < 1){
    //    //    if (GUI.Button(new Rect(10, 10, 200, 20), "Meet the flashing button")){
    //    //        print("You clicked me!");
    //    //    }
    //    //}

		float forwardForce = 0.0f;//actual amount we will move this frame
		forwardForce = Input.GetAxis("Vertical") * this.forwardAcceleration;
		
		//The faster we go, the less force that is applied by the engine
		if (this.GetComponent<Rigidbody>().velocity.magnitude > maxiumSpeed)
		{
			forwardForce = 0;
		}
		else
		{
			forwardForce *= (maxiumSpeed - this.GetComponent<Rigidbody>().velocity.magnitude) / maxiumSpeed;
		}

        GUI.Button(new Rect(10, 10, 200, 60), "Velocity: " + this.GetComponent<Rigidbody>().velocity.magnitude + "\nAxis: " + Input.GetAxis("Vertical")
		           + "\n "+forwardForce);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float forwardForce = 0.0f;//actual amount we will move this frame
        forwardForce = Input.GetAxis("Vertical") * this.forwardAcceleration;

        //The faster we go, the less force that is applied by the engine
        if (this.GetComponent<Rigidbody>().velocity.magnitude > maxiumSpeed)
        {
            forwardForce = 0;
        }
        else
        {
            forwardForce *= (maxiumSpeed - this.GetComponent<Rigidbody>().velocity.magnitude) / maxiumSpeed;
        }
        

        //float speedBoost = this.forwardAcceleration * Time.fixedDeltaTime * Input.GetAxis("Vertical");

        //if (this.rigidbody.velocity.magnitude > this.maxiumSpeed)
        //{
        //    speedBoost = 0;
        //}
        //else
        //{
        //    speedBoost *= (maxiumSpeed - this.rigidbody.velocity.magnitude) / maxiumSpeed;
        //}

        //this.rigidbody.velocity += this.rigidbody.transform.forward * speedBoost;

        float turnAmount = 0.0f;//actual amount we will turn this frame
        float adjustedAxis = Input.GetAxis("Horizontal");
        if (Mathf.Abs(adjustedAxis) < this.joystickHorizontalDeadZone)
        {
            adjustedAxis = 0;
        }
        else if (adjustedAxis > 0)
        {
            adjustedAxis = (adjustedAxis - this.joystickHorizontalDeadZone) * (1.0f / this.joystickHorizontalDeadZone);

        }
        else
        {
            adjustedAxis = (adjustedAxis + this.joystickHorizontalDeadZone) * (1.0f / this.joystickHorizontalDeadZone);
        }

        turnAmount = adjustedAxis * this.turnSpeed;

		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > this.joystickHorizontalDeadZone) {
			if (!audio.isPlaying) {
				audio.Play ();
			}
		} else if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0) {
			if (!audio.isPlaying) {
				audio.Play ();
			}
		} else {
			audio.Pause ();
		}

        this.transform.Rotate(0, turnAmount, 0);
        this.GetComponent<Rigidbody>().AddRelativeForce(forwardForce * Vector3.forward);

    }
}
