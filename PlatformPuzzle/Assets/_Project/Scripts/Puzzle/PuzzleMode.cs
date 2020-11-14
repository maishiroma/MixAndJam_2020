namespace Puzzle
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Base;

    public class PuzzleMode : MonoBehaviour
    {
        private static PuzzleController controller;

        public Vector2 failZoneSize;
        public GameObject[] listOfPossiblePieces;
        public Transform spawnLocation;

        [SerializeField]
        private bool hasFailed;

        public bool HasFailed
        {
            get { return hasFailed; }
        }

        private void Awake()
        {
            if(controller == null)
            {
                controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PuzzleController>();
            }
        }

        private void Update()
        {
            if(!hasFailed)
            {
                if (!controller.HasPiece())
                {
                    if (!Physics2D.BoxCast(spawnLocation.position, failZoneSize, 0f, Vector2.up))
                    {
                        int rand = Random.Range(0, listOfPossiblePieces.Length);
                        GameObject newPiece = Instantiate(listOfPossiblePieces[rand], spawnLocation.position, Quaternion.identity);

                        controller.AssignPiece(newPiece);
                    }
                    else
                    {
                        hasFailed = true;
                    }
                }
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(spawnLocation.position, failZoneSize);
        }

    }

}