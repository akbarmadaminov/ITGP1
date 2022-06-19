using UnityEngine;

namespace DefaultNamespace
{
    public class FinishTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            var player = other.GetComponent<PlayerMovement>();
            var Player = other.GetComponent<Player>();
            if (player != null)
            {
                Debug.Log("You win!\nYour score is: " + Player.counter);
                player.enabled = false;
            }
        }
    }
}