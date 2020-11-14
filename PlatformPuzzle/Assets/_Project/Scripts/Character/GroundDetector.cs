namespace Player
{
    using UnityEngine;

    public class GroundDetector : MonoBehaviour
    {
        public string groundTag = "Ground";
        
        [SerializeField]
        private bool isGrounded;

        public bool IsGrounded
        {
            get { return isGrounded; }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if(collision.CompareTag(groundTag))
            {
                isGrounded = true;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if(collision.CompareTag(groundTag))
            {
                isGrounded = false;
            }
        }
    }

}