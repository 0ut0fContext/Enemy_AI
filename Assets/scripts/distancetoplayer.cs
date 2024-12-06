using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToPlayer : MonoBehaviour
{
    public Transform player;
    public float DetectionDistance = 5.0f;

    // Update is called once per frame
    void Update()
    {
        float DistanceToPlayer = Vector3.Distance (transform.position, player.position);

        if (DistanceToPlayer <= DetectionDistance)
        {
            Debug.Log("player is close enough");
        }

    }
}
