namespace Puzzle
{
    using UnityEngine;
    using Base;

    public class PuzzleDetection : MonoBehaviour
    {
        private static AudioSource sfxPlayer;

        public float timeToStandStill = 1f;
        public Rigidbody2D pieceRB;

        public SFXWrapper landedSound;

        public Sprite previewImage;

        private bool isPlaced = false;
        private float currTime;

        public bool IsPlaced
        {
            get { return isPlaced; }
        }

        private void Awake()
        {
            if(sfxPlayer == null)
            {
                sfxPlayer = GameObject.FindGameObjectWithTag("SFX").GetComponent<AudioSource>();
            }
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            if (checkIfTouchingGround(collision.gameObject.tag) && isPlaced == false)
            {
                currTime += Time.deltaTime;
                if (currTime > timeToStandStill)
                {
                    isPlaced = true;
                    pieceRB.isKinematic = true;
                    pieceRB.velocity = Vector2.zero;

                    landedSound.PlaySoundClip(sfxPlayer);
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