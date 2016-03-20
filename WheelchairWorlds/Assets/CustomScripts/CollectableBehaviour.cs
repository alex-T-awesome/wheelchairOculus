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
        if (Input.GetKeyUp(KeyCode.H))
        {
            collectableObject.GetComponentInChildren<MeshRenderer>().enabled = !gameObject.GetComponentInChildren<MeshRenderer>().enabled;
            collectableObject.GetComponent<Collider>().enabled = !collectableObject.GetComponent<Collider>().enabled;
        }
	
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
