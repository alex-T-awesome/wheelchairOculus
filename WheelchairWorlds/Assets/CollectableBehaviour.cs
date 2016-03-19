using UnityEngine;
using System.Collections;

public class CollectableBehaviour : MonoBehaviour {

	public GameObject collectableObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	private void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "PlayerController")
		{
			collectableObject.SetActive (false);
		}
	}
}
