using UnityEngine;

namespace DefaultNamespace
{
    public class FinishTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            var player = other.GetComponent<PlayerMovement>();
            if (player != null)
            {
                Debug.Log("Game is finished!\nYou win!");
                player.enabled = false;
            }
        }
    }
}