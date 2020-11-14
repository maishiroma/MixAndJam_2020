namespace Puzzle
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.InputSystem;
    using Base;
    using Player;

    public class PuzzleTrigger : MonoBehaviour
    {
        public string playerTag = "Player";
        public Vector2 lookCameraAtPos;
        
        public PuzzleMode associatedPuzzleMode;
        public FollowPlayer mainCamera;

        private Player.PlayerController playerController;
        private bool canToggleBetween;
        private InputControls controls;      // Ref to the controls input that we are using for the project

        // Activates all of the controls for the player
        private void Awake()
        {
            // We need to first set this to be a new object before we can do anything
            controls = new InputControls();

            // Then we can set up calllbacks to specific methods that we want the controls to listen to
            controls.Player_Platform.PuzzleModeToggle.performed += ctx => ToggleMode(ctx);

            controls.Player_Puzzle.HardReset.performed += ctx => HardResetPuzzle(ctx);
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

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.CompareTag(playerTag) && canToggleBetween == false)
            {
                canToggleBetween = true;
                playerController = collision.GetComponent<Player.PlayerController>();
                mainCamera.StartTransition(lookCameraAtPos);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag(playerTag))
            {
                canToggleBetween = false;
                playerController = null;
                mainCamera.RevertBack();
            }
        }

        private void ToggleMode(InputAction.CallbackContext ctx)
        {
            if (canToggleBetween && ctx.ReadValueAsButton())
            {
                if(playerController.CurrentState == PlayerStates.PLATFORM)
                {
                    associatedPuzzleMode.gameObject.SetActive(true);
                    playerController.SwitchToPuzzleMode();
                }
                else
                {
                    associatedPuzzleMode.ResetMode(false);
                    playerController.ReturnToPlatformMode();
                }
            }
        }

        private void HardResetPuzzle(InputAction.CallbackContext ctx)
        {
            if (canToggleBetween && ctx.ReadValueAsButton())
            {
                if (playerController.CurrentState == PlayerStates.PUZZLE)
                {
                    associatedPuzzleMode.ResetMode(true);
                    playerController.ReturnToPlatformMode();
                }
            }
        }

    }

}