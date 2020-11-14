namespace Puzzle
{
    using System.Collections;
    using Base;
    using Player;
    using UnityEngine;
    using UnityEngine.InputSystem;

    public class PuzzleController : MonoBehaviour
    {
        public float moveSpeed;
        public float stopAcceeleration;
        public float fallSpeed;
        public float fastFallSpeed;

        private Vector2 movementInput;
        private bool isFastFall;
        private float beforeFastFally;

        private Player.CharacterController characterController;

        private Rigidbody2D currPiece;
        private PuzzleDetection pieceDetector;
        private InputControls controls;      // Ref to the controls input that we are using for the project

        // Activates all of the controls for the player
        private void Awake()
        {
            // We need to first set this to be a new object before we can do anything
            controls = new InputControls();

            // Then we can set up calllbacks to specific methods that we want the controls to listen to
            controls.Player_Puzzle.Movement.performed += ctx => GrabMovement(ctx);
            controls.Player_Puzzle.Movement.canceled += ctx => GrabMovement(ctx);

            controls.Player_Puzzle.FastFall.started += ctx => FastFall(ctx);
            controls.Player_Puzzle.FastFall.canceled += ctx => FastFall(ctx);

            controls.Player_Puzzle.Rotate.started += ctx => Rotate(ctx);
        }

        // Enables the controls when the player is active
        private void OnEnable()
        {
            controls.Enable();
        }

        // Diables the controls when the player is not active
        private void OnDisable()
        {
            controls.Disable();
            
            currPiece = null;
            pieceDetector = null;
            isFastFall = false;
            beforeFastFally = 0f;
        }

        private void Start()
        {
            movementInput = new Vector2();

            characterController = gameObject.GetComponent<Player.CharacterController>();
        }

        private void GrabMovement(InputAction.CallbackContext ctx)
        {
            movementInput.x = moveSpeed * ctx.ReadValue<float>();
        }

        private void FastFall(InputAction.CallbackContext ctx)
        {
            bool prevVal = isFastFall;
            isFastFall = ctx.ReadValueAsButton();

            if(prevVal == false && isFastFall == true)
            {
                beforeFastFally = currPiece.velocity.y;
            }
            else if(prevVal == true && isFastFall == false)
            {
                currPiece.velocity = new Vector2(currPiece.velocity.x, beforeFastFally);
            }
        }

        private void Rotate(InputAction.CallbackContext ctx)
        {
            if (currPiece != null)
            {
                float currZRot = currPiece.transform.rotation.eulerAngles.z;
                currPiece.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, currZRot + 90f));
            }
        }

        private void FixedUpdate()
        {
            if (currPiece != null && characterController.CurrentState == PlayerStates.PUZZLE)
            {
                Vector2 velocityOverTime;
                if (movementInput != Vector2.zero)
                {
                    velocityOverTime = Vector2.Lerp(currPiece.velocity, movementInput, Time.deltaTime);
                }
                else
                {
                    velocityOverTime = Vector2.Lerp(currPiece.velocity, new Vector2(0f, currPiece.velocity.y), stopAcceeleration * Time.deltaTime);
                }

                Vector2 gravityScale = Vector2.zero;
                if (isFastFall)
                {
                    gravityScale = new Vector2(0f, -fastFallSpeed);
                }
                else
                {
                    gravityScale = new Vector2(0f, -fallSpeed);
                }

                currPiece.velocity = velocityOverTime + gravityScale;
            }
        }

        public void AssignPiece(GameObject newPiece)
        {
            currPiece = newPiece.GetComponent<Rigidbody2D>();
            pieceDetector = newPiece.GetComponent<PuzzleDetection>();
        }

        public bool HasPiece()
        {
            if(pieceDetector != null && pieceDetector.IsPlaced == false)
            {
                return true;
            }
            return false;
        }
    }

}