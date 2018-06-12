using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsMenuController : MonoBehaviour {


    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
