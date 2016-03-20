using UnityEngine;
using System.Collections;

public class CollectableBehaviour : MonoBehaviour {

	public GameObject collectableObject;
	public AudioClip jingle;
	public float volume;

	// Use this for initialization
	void Start () {
		volume = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "PlayerController")
		{
			AudioSource.PlayClipAtPoint (jingle, transform.position, volume);
			Destroy(collectableObject);
		}
	}
}
