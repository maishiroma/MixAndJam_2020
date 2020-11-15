namespace Puzzle
{
    using System.Collections.Generic;
    using UnityEngine;
    using Base;
    using UnityEngine.UI;

    public class PuzzleMode : MonoBehaviour
    {
        private static Player.PlayerController characterController;

        public Vector2 failZoneSize;
        public GameObject[] listOfPossiblePieces;
        public Transform spawnLocation;

        public Image nextPiecePreview;

        public AudioSource sfxPlayer;
        public SFXWrapper resetSound;

        [SerializeField]
        private bool hasFailed = false;

        private int nextPieceIndex = -1;
        private GameObject newPiece;
        private List<GameObject> allPlacedPieces;

        public bool HasFailed
        {
            get { return hasFailed; }
        }

        private void Awake()
        {
            if(characterController == null)
            {
                characterController = GameObject.FindGameObjectWithTag("Player").GetComponent<Player.PlayerController>();
            }
        }

        private void OnEnable()
        {
            hasFailed = false;
        }

        private void OnDisable()
        {
            nextPiecePreview.gameObject.SetActive(false);
        }

        private void Start()
        {
            allPlacedPieces = new List<GameObject>();
        }

        private void Update()
        {
            if(!hasFailed)
            {
                if (!characterController.puzzleControls.HasPiece())
                {
                    if (!Physics2D.BoxCast(spawnLocation.position, failZoneSize, 0f, Vector2.up))
                    {
                        SpawnPiece();
                    }
                    else
                    {
                        ResetMode(true);
                        characterController.ReturnToPlatformMode();
                    }
                }
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(spawnLocation.position, failZoneSize);
        }

        private void SpawnPiece()
        {
            if (nextPieceIndex == -1)
            {
                int rand = Random.Range(0, listOfPossiblePieces.Length);
                newPiece = Instantiate(listOfPossiblePieces[rand], spawnLocation.position, Quaternion.identity);
            }
            else
            {
                newPiece = Instantiate(listOfPossiblePieces[nextPieceIndex], spawnLocation.position, Quaternion.identity);
            }

            nextPieceIndex = Random.Range(0, listOfPossiblePieces.Length);
            SetPreviewImage();

            characterController.puzzleControls.AssignPiece(newPiece);
            allPlacedPieces.Add(newPiece);
        }

        private void ClearAllPieces()
        {
            foreach(GameObject currPiece in allPlacedPieces)
            {
                Destroy(currPiece);
            }

            allPlacedPieces.Clear();
        }

        public void ResetMode(bool removePieces)
        {
            gameObject.SetActive(false);
            hasFailed = true;
            nextPieceIndex = -1;

            if(newPiece != null)
            {
                Destroy(newPiece);
            }
            
            if(removePieces)
            {
                ClearAllPieces();
            }

            resetSound.PlaySoundClip(sfxPlayer);
        }

        private void SetPreviewImage()
        {
            if(nextPiecePreview.gameObject.activeInHierarchy == false)
            {
                nextPiecePreview.gameObject.SetActive(true);
            }

            PuzzleDetection futurePiece = listOfPossiblePieces[nextPieceIndex].GetComponentInChildren<PuzzleDetection>();

            nextPiecePreview.sprite = futurePiece.previewImage;
        }
    }

}