using UnityEngine;
using System.Collections;

public class CollectableBehaviour : MonoBehaviour {

	public GameObject collectableObject;
	public AudioClip jingle;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "PlayerController")
		{
			AudioSource.PlayClipAtPoint (jingle, transform.position);
			Destroy(collectableObject);
		}
	}
}
