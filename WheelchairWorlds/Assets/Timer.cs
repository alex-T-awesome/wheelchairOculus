using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public TextMesh timeDisplay;

	string minutes;
	string seconds;

	// Update is called once per frame
	void Update () {
		minutes = Mathf.Floor(Time.time / 60).ToString("00");
		seconds = Mathf.Floor(Time.time % 60).ToString("00");
		timeDisplay.text = minutes + ":" + seconds ;
	}
}
