namespace Puzzle
{
    using UnityEngine;

    public class PuzzleDetection : MonoBehaviour
    {
        public float timeToStandStill = 1f;
        public Rigidbody2D pieceRB;

        private bool isPlaced = false;
        private float currTime;

        public bool IsPlaced
        {
            get { return isPlaced; }
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            if (checkIfTouchingGround(collision.gameObject.tag) && isPlaced == false)
            {
                currTime += Time.deltaTime;
                if (currTime > timeToStandStill)
                {
                    isPlaced = true;
                }
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if(checkIfTouchingGround(collision.gameObject.tag))
            {
                currTime = 0;
            }
        }

        private bool checkIfTouchingGround(string tagCompare)
        {
            if (tagCompare == "Ground" || tagCompare == "PuzzlePiece")
            {
                if(pieceRB.velocity.y <= 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}