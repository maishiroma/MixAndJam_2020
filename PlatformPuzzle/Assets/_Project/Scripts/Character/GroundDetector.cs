namespace Player
{
    using UnityEngine;

    public class GroundDetector : MonoBehaviour
    {
        public string[] groundTags = { "Ground" };
        
        [SerializeField]
        private bool isGrounded;

        public bool IsGrounded
        {
            get { return isGrounded; }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if(CheckTagArray(collision.gameObject.tag))
            {
                isGrounded = true;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if(CheckTagArray(collision.gameObject.tag))
            {
                isGrounded = false;
            }
        }

        private bool CheckTagArray(string tagToCompare)
        {
            foreach(string currTag in groundTags)
            {
                if(tagToCompare == currTag)
                {
                    return true;
                }
            }
            return false;
        }
    }

}