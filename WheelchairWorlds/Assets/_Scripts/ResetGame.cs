using UnityEngine;
using System.Collections;

public class ResetGame : MonoBehaviour {


	void Start () {
	
	}
	
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space)){
            Application.LoadLevel(Application.loadedLevel);
        }
	}
}
