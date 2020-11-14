namespace Player
{
    using Base;
    using UnityEngine;
    using System.Collections;

    public class FollowPlayer : MonoBehaviour
    {
        public Rigidbody2D playerObj;
        
        [SerializeField]
        private Vector2 offset;

        [SerializeField]
        private CameraStates currentState;

        private Vector2 newPos = Vector2.zero;
        private Vector2 prevOffset;
        private float cameraZ;

        private void Start()
        {
            cameraZ = gameObject.transform.position.z;
            prevOffset = offset;
            currentState = CameraStates.TRACKING;
        }


        private void LateUpdate()
        {
            Vector2 newOffset = playerObj.position + offset;
            switch (currentState)
            {
                case CameraStates.TRACKING:
                    newPos = newOffset;
                    break;
                case CameraStates.TRANSITION:
                case CameraStates.REVERT:
                    newPos = Vector2.Lerp(gameObject.transform.position, newOffset,  Time.fixedDeltaTime);
                    break;
            }

            gameObject.transform.position = new Vector3(newPos.x, newPos.y, cameraZ);
        }

        private IEnumerator ChangeToState(CameraStates newState)
        {
            yield return new WaitForSeconds(0.5f);
            currentState = newState;
        }

        public void StartTransition(Vector2 newOffset)
        {
            if(currentState != CameraStates.TRANSITION || currentState != CameraStates.NEW_SPOT)
            {
                currentState = CameraStates.TRANSITION;
                offset = newOffset;
                StartCoroutine(ChangeToState(CameraStates.NEW_SPOT));
            }
        }

        public void RevertBack()
        {
            if(currentState != CameraStates.REVERT)
            {
                currentState = CameraStates.REVERT;
                offset = prevOffset;
                StartCoroutine(ChangeToState(CameraStates.TRACKING));
            }

        }

    }
}