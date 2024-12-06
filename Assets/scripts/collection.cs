using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collection : MonoBehaviour
{
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            GameManager gameManager = FindAnyObjectByType<GameManager>();
            if (gameManager !=null)
                    {
                gameManager.AddCollectedCoin(1);
                    }
            Destroy(gameObject);
        }
    }
}
