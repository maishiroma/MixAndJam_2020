// GENERATED AUTOMATICALLY FROM 'Assets/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Base
{
    public class @InputControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""Player_Platform"",
            ""id"": ""3d3e82dd-3929-4966-9c78-65245553509d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""1d3590a4-f939-4d83-9fb4-72bdc5606477"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""58780128-9d65-43af-a62d-80b9b87ec0fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PuzzleMode"",
                    ""type"": ""Button"",
                    ""id"": ""2c4d2212-a939-47f7-a085-8d516edb5820"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""fb42f5a1-9fc2-407b-bbeb-e577dbee9176"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c86ac93f-afea-4ab4-8ee6-abdf04cb6d94"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0f3d8f53-4ea1-4d53-acca-4e3c9b795682"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1b4eef58-7f28-429f-a23f-7e1f26031bb5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a29e65c1-1481-4be8-acfb-b26ed147e17f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""92871214-6278-42ef-9c0e-909461e9ed90"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5b5ca7f1-7ceb-4b25-a8d8-36efd36e54c5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d317a94-b708-4bf4-b584-0ff4482e3239"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PuzzleMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d7395a7-cff4-473f-8805-845733cba179"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PuzzleMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player_Puzzle"",
            ""id"": ""774d1c15-ba54-4baa-ad18-6e940a458032"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""0993569d-533d-4636-94cc-097a25dd7a89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fast Fall"",
                    ""type"": ""Button"",
                    ""id"": ""1a59e606-dd37-45e3-a4c4-cf066ba2bd3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""e1dd529b-4f54-4d6f-9ee3-102b5567efba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c4b3ac02-3d02-4146-a15d-71ef3ceccbbe"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ab608348-9af1-490b-ad53-82f28ec34555"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ae14feb5-9a64-4b4f-836c-58c93be97629"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""34c49edb-8372-498e-bc17-86309b940285"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7d48aad6-09fb-4b04-8041-097e106be949"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b40fcb7d-b6a6-4948-804c-c0a11c561e55"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1e468791-685b-428a-a272-5f2051815cc9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fast Fall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""356560ce-c6fd-4b57-8a89-c6043331cb68"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fast Fall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1736730c-3913-47fe-be6f-487f310d4367"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player_Platform
            m_Player_Platform = asset.FindActionMap("Player_Platform", throwIfNotFound: true);
            m_Player_Platform_Movement = m_Player_Platform.FindAction("Movement", throwIfNotFound: true);
            m_Player_Platform_Jump = m_Player_Platform.FindAction("Jump", throwIfNotFound: true);
            m_Player_Platform_PuzzleMode = m_Player_Platform.FindAction("PuzzleMode", throwIfNotFound: true);
            // Player_Puzzle
            m_Player_Puzzle = asset.FindActionMap("Player_Puzzle", throwIfNotFound: true);
            m_Player_Puzzle_Movement = m_Player_Puzzle.FindAction("Movement", throwIfNotFound: true);
            m_Player_Puzzle_FastFall = m_Player_Puzzle.FindAction("Fast Fall", throwIfNotFound: true);
            m_Player_Puzzle_Rotate = m_Player_Puzzle.FindAction("Rotate", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Player_Platform
        private readonly InputActionMap m_Player_Platform;
        private IPlayer_PlatformActions m_Player_PlatformActionsCallbackInterface;
        private readonly InputAction m_Player_Platform_Movement;
        private readonly InputAction m_Player_Platform_Jump;
        private readonly InputAction m_Player_Platform_PuzzleMode;
        public struct Player_PlatformActions
        {
            private @InputControls m_Wrapper;
            public Player_PlatformActions(@InputControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Player_Platform_Movement;
            public InputAction @Jump => m_Wrapper.m_Player_Platform_Jump;
            public InputAction @PuzzleMode => m_Wrapper.m_Player_Platform_PuzzleMode;
            public InputActionMap Get() { return m_Wrapper.m_Player_Platform; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(Player_PlatformActions set) { return set.Get(); }
            public void SetCallbacks(IPlayer_PlatformActions instance)
            {
                if (m_Wrapper.m_Player_PlatformActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_Player_PlatformActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_Player_PlatformActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_Player_PlatformActionsCallbackInterface.OnMovement;
                    @Jump.started -= m_Wrapper.m_Player_PlatformActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_Player_PlatformActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_Player_PlatformActionsCallbackInterface.OnJump;
                    @PuzzleMode.started -= m_Wrapper.m_Player_PlatformActionsCallbackInterface.OnPuzzleMode;
                    @PuzzleMode.performed -= m_Wrapper.m_Player_PlatformActionsCallbackInterface.OnPuzzleMode;
                    @PuzzleMode.canceled -= m_Wrapper.m_Player_PlatformActionsCallbackInterface.OnPuzzleMode;
                }
                m_Wrapper.m_Player_PlatformActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @PuzzleMode.started += instance.OnPuzzleMode;
                    @PuzzleMode.performed += instance.OnPuzzleMode;
                    @PuzzleMode.canceled += instance.OnPuzzleMode;
                }
            }
        }
        public Player_PlatformActions @Player_Platform => new Player_PlatformActions(this);

        // Player_Puzzle
        private readonly InputActionMap m_Player_Puzzle;
        private IPlayer_PuzzleActions m_Player_PuzzleActionsCallbackInterface;
        private readonly InputAction m_Player_Puzzle_Movement;
        private readonly InputAction m_Player_Puzzle_FastFall;
        private readonly InputAction m_Player_Puzzle_Rotate;
        public struct Player_PuzzleActions
        {
            private @InputControls m_Wrapper;
            public Player_PuzzleActions(@InputControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Player_Puzzle_Movement;
            public InputAction @FastFall => m_Wrapper.m_Player_Puzzle_FastFall;
            public InputAction @Rotate => m_Wrapper.m_Player_Puzzle_Rotate;
            public InputActionMap Get() { return m_Wrapper.m_Player_Puzzle; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(Player_PuzzleActions set) { return set.Get(); }
            public void SetCallbacks(IPlayer_PuzzleActions instance)
            {
                if (m_Wrapper.m_Player_PuzzleActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_Player_PuzzleActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_Player_PuzzleActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_Player_PuzzleActionsCallbackInterface.OnMovement;
                    @FastFall.started -= m_Wrapper.m_Player_PuzzleActionsCallbackInterface.OnFastFall;
                    @FastFall.performed -= m_Wrapper.m_Player_PuzzleActionsCallbackInterface.OnFastFall;
                    @FastFall.canceled -= m_Wrapper.m_Player_PuzzleActionsCallbackInterface.OnFastFall;
                    @Rotate.started -= m_Wrapper.m_Player_PuzzleActionsCallbackInterface.OnRotate;
                    @Rotate.performed -= m_Wrapper.m_Player_PuzzleActionsCallbackInterface.OnRotate;
                    @Rotate.canceled -= m_Wrapper.m_Player_PuzzleActionsCallbackInterface.OnRotate;
                }
                m_Wrapper.m_Player_PuzzleActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @FastFall.started += instance.OnFastFall;
                    @FastFall.performed += instance.OnFastFall;
                    @FastFall.canceled += instance.OnFastFall;
                    @Rotate.started += instance.OnRotate;
                    @Rotate.performed += instance.OnRotate;
                    @Rotate.canceled += instance.OnRotate;
                }
            }
        }
        public Player_PuzzleActions @Player_Puzzle => new Player_PuzzleActions(this);
        private int m_KeyboardSchemeIndex = -1;
        public InputControlScheme KeyboardScheme
        {
            get
            {
                if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
                return asset.controlSchemes[m_KeyboardSchemeIndex];
            }
        }
        public interface IPlayer_PlatformActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnPuzzleMode(InputAction.CallbackContext context);
        }
        public interface IPlayer_PuzzleActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnFastFall(InputAction.CallbackContext context);
            void OnRotate(InputAction.CallbackContext context);
        }
    }
}
