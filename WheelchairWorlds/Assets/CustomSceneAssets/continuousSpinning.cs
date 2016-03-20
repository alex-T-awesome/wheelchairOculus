using UnityEngine;
using System.Collections;

public class continuousSpinning : MonoBehaviour {

    public float rotationSpeedDegreesPerSec = 60.0f;
    public Vector3 axisOfRotation = Vector3.forward;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(axisOfRotation, rotationSpeedDegreesPerSec * Time.deltaTime);
	}
}
