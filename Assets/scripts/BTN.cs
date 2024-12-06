using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BTN : MonoBehaviour
{
    public GameObject pauseCanvas; 

    public void NewLevelBTN(string newLevel)
    {
        SceneManager.LoadScene(newLevel);
    }
    // Start is called before the first frame update
    public void ExitGameBTN()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
