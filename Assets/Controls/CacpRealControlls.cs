// GENERATED AUTOMATICALLY FROM 'Assets/Controls/CacpRealControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CacpRealControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CacpRealControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CacpRealControlls"",
    ""maps"": [
        {
            ""name"": ""MovementSchemeFighting"",
            ""id"": ""962e5fc2-de92-450a-bbf4-e6a552466d13"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""2afb2ef5-dfa5-402b-9eb7-12caf3162f26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""left"",
                    ""type"": ""Button"",
                    ""id"": ""60465ddf-378e-4d0e-aa3c-a3e7985f0f78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""right"",
                    ""type"": ""Button"",
                    ""id"": ""0a8b9124-0ba9-4ed4-acad-5d592b77f209"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8d2b9089-e349-4830-ac1e-c1c3821df770"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""51287e7f-79b0-413c-9977-229e1a5973f3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""708a96ba-37d4-4bed-ad8c-3c743252ede3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ecb6c10-8eed-4e6b-8632-7f8853840349"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3530a55f-a8f2-47b7-8dc3-d7ebc174f5c7"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e811639-b2c4-4d41-8dab-036bf9381c7f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71157d06-acfd-4447-97c2-7a1f2f9cbe4b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d120860-7e86-46aa-8ca1-5e238a6cbd40"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d523a6d-fe06-49ce-8ca2-d4ba5b2f4754"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d67e0fa-c31a-4070-bb28-b5773912eca7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a00a137e-9154-4088-ba55-c6f67a58ac14"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""959dc297-b8f2-44ac-bf59-a5a1542b838c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""395766f0-0dd7-419c-af54-e19bf2e7ec17"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""016a6a6b-c547-4335-9444-6bfbb741c58a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cf848ce-380e-454a-aed0-4cb698194f3e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ui"",
            ""id"": ""24ae80f0-9918-4270-b97f-d2cf1862ff60"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""80a237a6-4d47-4cff-b7da-3339a13fb151"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""ca648268-5bc4-4d44-8a4c-50dc5cde5579"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f77e6032-9d69-440e-8e2f-764d5a929c83"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cd13d47-34a7-42bc-a726-8ffe4402a145"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cc8db71-bc4c-4c71-a7e5-5e8fcddc3354"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce8cdb75-e5eb-4bea-b6d3-5dc1e3fb2580"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MovementSchemeNoFighting"",
            ""id"": ""bb5d58e8-3b18-49c1-96b2-3859d9cad579"",
            ""actions"": [
                {
                    ""name"": ""right"",
                    ""type"": ""Button"",
                    ""id"": ""bb820ca2-642c-46b6-8a91-5613ee46380a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""left"",
                    ""type"": ""Button"",
                    ""id"": ""9e424d21-a060-4a08-8ef1-5d5e5e671c38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5e285892-7cdf-4a87-86a3-8ec30d1d6f12"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76781f99-3afd-4cd7-adfe-957c8420a647"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37cc47c6-2f23-4456-9671-4ad3286ac690"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5721155-81f7-4fed-ab04-f5be31c98123"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aead4d17-3d4c-46e3-99e0-3f9b8f284f6f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19dd2f81-0ba3-493c-a82b-53395fe893e1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cc827a2-7f0e-430e-8221-d708addf5f5d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2dbe7c98-4496-4c93-9535-f67a6e003ad5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FightingSceme"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""FightingSceme"",
            ""bindingGroup"": ""FightingSceme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MovementSchemeFighting
        m_MovementSchemeFighting = asset.FindActionMap("MovementSchemeFighting", throwIfNotFound: true);
        m_MovementSchemeFighting_Jump = m_MovementSchemeFighting.FindAction("Jump", throwIfNotFound: true);
        m_MovementSchemeFighting_left = m_MovementSchemeFighting.FindAction("left", throwIfNotFound: true);
        m_MovementSchemeFighting_right = m_MovementSchemeFighting.FindAction("right", throwIfNotFound: true);
        m_MovementSchemeFighting_Shoot = m_MovementSchemeFighting.FindAction("Shoot", throwIfNotFound: true);
        // Ui
        m_Ui = asset.FindActionMap("Ui", throwIfNotFound: true);
        m_Ui_Pause = m_Ui.FindAction("Pause", throwIfNotFound: true);
        m_Ui_Exit = m_Ui.FindAction("Exit", throwIfNotFound: true);
        // MovementSchemeNoFighting
        m_MovementSchemeNoFighting = asset.FindActionMap("MovementSchemeNoFighting", throwIfNotFound: true);
        m_MovementSchemeNoFighting_right = m_MovementSchemeNoFighting.FindAction("right", throwIfNotFound: true);
        m_MovementSchemeNoFighting_left = m_MovementSchemeNoFighting.FindAction("left", throwIfNotFound: true);
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

    // MovementSchemeFighting
    private readonly InputActionMap m_MovementSchemeFighting;
    private IMovementSchemeFightingActions m_MovementSchemeFightingActionsCallbackInterface;
    private readonly InputAction m_MovementSchemeFighting_Jump;
    private readonly InputAction m_MovementSchemeFighting_left;
    private readonly InputAction m_MovementSchemeFighting_right;
    private readonly InputAction m_MovementSchemeFighting_Shoot;
    public struct MovementSchemeFightingActions
    {
        private @CacpRealControlls m_Wrapper;
        public MovementSchemeFightingActions(@CacpRealControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_MovementSchemeFighting_Jump;
        public InputAction @left => m_Wrapper.m_MovementSchemeFighting_left;
        public InputAction @right => m_Wrapper.m_MovementSchemeFighting_right;
        public InputAction @Shoot => m_Wrapper.m_MovementSchemeFighting_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_MovementSchemeFighting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementSchemeFightingActions set) { return set.Get(); }
        public void SetCallbacks(IMovementSchemeFightingActions instance)
        {
            if (m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnJump;
                @left.started -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnLeft;
                @left.performed -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnLeft;
                @left.canceled -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnLeft;
                @right.started -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnRight;
                @right.performed -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnRight;
                @right.canceled -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnRight;
                @Shoot.started -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @left.started += instance.OnLeft;
                @left.performed += instance.OnLeft;
                @left.canceled += instance.OnLeft;
                @right.started += instance.OnRight;
                @right.performed += instance.OnRight;
                @right.canceled += instance.OnRight;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public MovementSchemeFightingActions @MovementSchemeFighting => new MovementSchemeFightingActions(this);

    // Ui
    private readonly InputActionMap m_Ui;
    private IUiActions m_UiActionsCallbackInterface;
    private readonly InputAction m_Ui_Pause;
    private readonly InputAction m_Ui_Exit;
    public struct UiActions
    {
        private @CacpRealControlls m_Wrapper;
        public UiActions(@CacpRealControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Ui_Pause;
        public InputAction @Exit => m_Wrapper.m_Ui_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Ui; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UiActions set) { return set.Get(); }
        public void SetCallbacks(IUiActions instance)
        {
            if (m_Wrapper.m_UiActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_UiActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnPause;
                @Exit.started -= m_Wrapper.m_UiActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_UiActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public UiActions @Ui => new UiActions(this);

    // MovementSchemeNoFighting
    private readonly InputActionMap m_MovementSchemeNoFighting;
    private IMovementSchemeNoFightingActions m_MovementSchemeNoFightingActionsCallbackInterface;
    private readonly InputAction m_MovementSchemeNoFighting_right;
    private readonly InputAction m_MovementSchemeNoFighting_left;
    public struct MovementSchemeNoFightingActions
    {
        private @CacpRealControlls m_Wrapper;
        public MovementSchemeNoFightingActions(@CacpRealControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @right => m_Wrapper.m_MovementSchemeNoFighting_right;
        public InputAction @left => m_Wrapper.m_MovementSchemeNoFighting_left;
        public InputActionMap Get() { return m_Wrapper.m_MovementSchemeNoFighting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementSchemeNoFightingActions set) { return set.Get(); }
        public void SetCallbacks(IMovementSchemeNoFightingActions instance)
        {
            if (m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface != null)
            {
                @right.started -= m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface.OnRight;
                @right.performed -= m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface.OnRight;
                @right.canceled -= m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface.OnRight;
                @left.started -= m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface.OnLeft;
                @left.performed -= m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface.OnLeft;
                @left.canceled -= m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface.OnLeft;
            }
            m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @right.started += instance.OnRight;
                @right.performed += instance.OnRight;
                @right.canceled += instance.OnRight;
                @left.started += instance.OnLeft;
                @left.performed += instance.OnLeft;
                @left.canceled += instance.OnLeft;
            }
        }
    }
    public MovementSchemeNoFightingActions @MovementSchemeNoFighting => new MovementSchemeNoFightingActions(this);
    private int m_FightingScemeSchemeIndex = -1;
    public InputControlScheme FightingScemeScheme
    {
        get
        {
            if (m_FightingScemeSchemeIndex == -1) m_FightingScemeSchemeIndex = asset.FindControlSchemeIndex("FightingSceme");
            return asset.controlSchemes[m_FightingScemeSchemeIndex];
        }
    }
    public interface IMovementSchemeFightingActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IUiActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IMovementSchemeNoFightingActions
    {
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
    }
}
