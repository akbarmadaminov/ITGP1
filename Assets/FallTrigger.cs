using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerMovement>();
        if (player != null)
        {
            Debug.Log("Game is finished!\nYou lose!");
            player.enabled = false;
        }
    }
}
