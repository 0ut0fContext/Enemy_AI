using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPossition : MonoBehaviour
{
    // movement speed of the coin
    public float moveSpeed = 1.0f;

    // hight of the coin 
    public float amplitude = 1.0f;

    // Store the initial position of the coin.
    private Vector3 startPos;

    // This method is called once when the script starts.
    void Start()
    {
        // Store the initial position of the cion.
        startPos = transform.position;
    }

    // This method is called once per frame.
    void Update()
    {
        // Calculate the vertical movement using Mathf.Sin to create an oscillation effect.
        // Time.time is a value that increases over time, creating a smooth oscillation.
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * amplitude;

        // Update the object's position by adding the vertical movement to its initial position.
        Vector3 newPosition = startPos + Vector3.up * verticalMovement;
        transform.position = newPosition;
    }
  
}