using UnityEngine;
using System.Collections;

public class WheelChairCollider : MonoBehaviour {

	public TextMesh HeadsUpDisplay;
    public TextMesh GameWinDisplay;
	int score = 0;
    GameObject[] gems;
    int gemsToCollect;
    int gemsCollected = 0;

    void Start()
    {
        gems = GameObject.FindGameObjectsWithTag("PickUp");
        gemsToCollect = gems.Length;
        HeadsUpDisplay.text = "Score: " + score + "\n" + "Progress: " + gemsCollected + "/" + gemsToCollect;
    }

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
            gemsCollected++;
			HeadsUpDisplay.text = "Score: " + score + "\n" + "Progress: " + gemsCollected + "/" + gemsToCollect;
            //Check if game is over
            if(gemsToCollect <= gemsCollected){
                //Game has been finished 
                GameWinDisplay.text = "You have collected all the gems!";

            }
		} else if (hit.gameObject.tag == "Avoid") {
			score--;
            HeadsUpDisplay.text = "Score: " + score + "\n" + "Progress: " + gemsCollected + "/" + gemsToCollect;
		}
	}
}
