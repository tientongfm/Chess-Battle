using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("TwoPlayersScene");
        
    }

    public void GamePlay()
    {
        SceneManager.LoadScene("InstructionsMenu");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
