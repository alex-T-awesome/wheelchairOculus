using UnityEngine;
using System.Collections;

public class WheelChairCollider : MonoBehaviour {

	public TextMesh HeadsUpDisplay;
	int score = 0;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.H))
        {
            HeadsUpDisplay.GetComponent<MeshRenderer>().enabled = !HeadsUpDisplay.GetComponent<MeshRenderer>().enabled;
        }
    }

	void OnCollisionEnter(Collision hit) {
		if (hit.gameObject.tag == "Pickup") {
			score++;
			HeadsUpDisplay.text = "" + score;
		} else if (hit.gameObject.tag == "Avoid") {
			score--;
			HeadsUpDisplay.text = "" + score;
		}
	}
}
