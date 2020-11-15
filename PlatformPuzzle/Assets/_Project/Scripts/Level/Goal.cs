namespace Level
{
    using UnityEngine;
    using Player;

    public class Goal : MonoBehaviour
    {
        public string playerTag = "Player";
        public int nextLevelIndex;

        private Player.PlayerController playerController;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(playerTag))
            {
                playerController = collision.GetComponent<Player.PlayerController>();
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if(playerController != null)
            {
                if(playerController.groundDetectors.IsGrounded)
                {
                    StartCoroutine(playerController.Advance(nextLevelIndex));
                }
            }
        }
            
    }

}