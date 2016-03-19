using UnityEngine;
using System.Collections;

public class SuperSimpleControl : MonoBehaviour
{

    public float forwardSpeed = 3.0f;
    public float turnSpeed = 2.0f;
    public float maxSpeed = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float forwardMoveAmount = 0.0f;//actual amount we will move this frame
        forwardMoveAmount = Input.GetAxis("Vertical") * this.forwardSpeed;
        //The faster we go, the less force that is applied by the engine
        forwardMoveAmount *= (maxSpeed - this.GetComponent<Rigidbody>().velocity.magnitude) / maxSpeed;
        if (forwardMoveAmount < 0)
        {
            forwardMoveAmount = 0;
        }

        float turnAmount = 0.0f;//actual amount we will turn this frame
        turnAmount = Input.GetAxis("Horizontal") * this.turnSpeed;

        this.transform.Rotate(0, turnAmount, 0);
        this.GetComponent<Rigidbody>().AddRelativeForce(0,0,forwardMoveAmount);
    }
}
