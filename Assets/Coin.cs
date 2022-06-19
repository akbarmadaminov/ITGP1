using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerMovement>();
        if (player != null)
        {
            var Player = other.GetComponent<Player>();
            Player.counter++;
            Debug.Log("Number of coins: " + Player.counter);
            Destroy(gameObject); 
        }
    }
}
