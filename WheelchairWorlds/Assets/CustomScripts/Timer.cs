using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public TextMesh timeDisplay;

	string minutes;
	string seconds;

	void Update () {
		minutes = Mathf.Floor(Time.time / 60).ToString("00");
		seconds = Mathf.Floor(Time.time % 60).ToString("00");
		timeDisplay.text = minutes + ":" + seconds;
        if (Input.GetKeyUp(KeyCode.H))
        {
            timeDisplay.GetComponent<MeshRenderer>().enabled = !timeDisplay.GetComponent<MeshRenderer>().enabled;
        }
	}
}
