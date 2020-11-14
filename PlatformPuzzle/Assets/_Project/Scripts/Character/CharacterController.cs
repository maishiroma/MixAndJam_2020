namespace Player
{
    using System.Collections;
    using Base;
    using Puzzle;
    using UnityEngine;
    using UnityEngine.InputSystem;
    
    public class CharacterController : MonoBehaviour
    {
        public float moveSpeed;
        public float stopAcceeleration;
        public float jumpPower;
        public float gravitySpeed;
        public float jumpDuration;

        public GroundDetector groundDetectors;
        public PuzzleController puzzleControls;

        // Private Vars
        private Rigidbody2D playerRB;
        private Vector2 movementInput;
        private PlayerStates currentState;
        private InputControls controls;      // Ref to the controls input that we are using for the project

        public PlayerStates CurrentState
        {
            get { return currentState; }
        }

        // Activates all of the controls for the player
        private void Awake()
        {
            // We need to first set this to be a new object before we can do anything
            controls = new InputControls();

            // Then we can set up calllbacks to specific methods that we want the controls to listen to
            controls.Player_Platform.Movement.performed += ctx => GrabMovement(ctx);
            controls.Player_Platform.Movement.canceled += ctx => GrabMovement(ctx);

            controls.Player_Platform.Jump.started += ctx => Jump(ctx);
            controls.Player_Platform.Jump.canceled += ctx => Jump(ctx);
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
        }

        private void Start()
        {
            currentState = PlayerStates.PLATFORM;
            movementInput = new Vector2();

            playerRB = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            if (currentState == PlayerStates.PLATFORM)
            {
                Vector2 velocityOverTime;
                if (movementInput != Vector2.zero)
                {
                    velocityOverTime = Vector2.Lerp(playerRB.velocity, movementInput, Time.deltaTime);
                }
                else
                {
                    velocityOverTime = Vector2.Lerp(playerRB.velocity, new Vector2(0f, playerRB.velocity.y), stopAcceeleration * Time.deltaTime);
                }

                Vector2 gravityScale = Vector2.zero;
                if (!groundDetectors.IsGrounded)
                {
                    gravityScale = new Vector2(0f, -gravitySpeed);
                }

                playerRB.velocity = velocityOverTime + gravityScale;
                //AnimatePlayerMovement();
            }
        }

        private void GrabMovement(InputAction.CallbackContext ctx)
        {
            movementInput.x = moveSpeed * ctx.ReadValue<float>();
        }

        private void Jump(InputAction.CallbackContext ctx)
        {
            if (groundDetectors.IsGrounded && movementInput.y == 0)
            {
                movementInput.y = jumpPower * ctx.ReadValue<float>();
                StartCoroutine(ResetIsJumping());
            }
        }

        private IEnumerator ResetIsJumping()
        {
            yield return new WaitForSeconds(jumpDuration);
            movementInput.y = 0;
        }
    
        public void SwitchToPuzzleMode()
        {
            if(currentState == PlayerStates.PLATFORM)
            {
                playerRB.isKinematic = true;
                playerRB.velocity = Vector2.zero;

                currentState = PlayerStates.PUZZLE;
                this.enabled = false;
                puzzleControls.enabled = true;
            }
        }
    
        public void ReturnToPlatformMode()
        {
            if(currentState == PlayerStates.PUZZLE)
            {
                playerRB.isKinematic = false;

                currentState = PlayerStates.PLATFORM;
                this.enabled = true;
                puzzleControls.enabled = false;
            }
        }
    }

}