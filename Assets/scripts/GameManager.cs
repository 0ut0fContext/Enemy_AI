using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int CollectedCoin = 0;
    private bool ispaused = false;

    // Update is called once per frame
    public void AddCollectedCoin(int amount)
    {
        CollectedCoin += amount;

        if (CollectedCoin >= 15)
        {
            SceneManager.LoadScene("You Won!");


        }
    }

    void Update()
    {
        Pause();
    }

    void Pause()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (ispaused)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.0f;
            }
            ispaused = !ispaused;
        }
    }
}
