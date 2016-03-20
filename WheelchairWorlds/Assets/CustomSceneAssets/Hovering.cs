using UnityEngine;
using System.Collections;

public class Hovering : MonoBehaviour {

	public GameObject gem;

	public float amplitude;
	public int hoverSpeed;
	public float rotationSpeed;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * amplitude * Mathf.Sin (hoverSpeed * Time.time), Space.World);
		transform.Rotate (0, 0, rotationSpeed);
	}
}
