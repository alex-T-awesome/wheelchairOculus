using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {


	void Start () {
	
	}
	
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
