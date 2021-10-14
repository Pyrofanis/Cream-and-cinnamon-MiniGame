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
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8d2b9089-e349-4830-ac1e-c1c3821df770"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""9fa9f21d-fa10-48a3-b24c-78c94871121e"",
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
                },
                {
                    ""name"": ""PcAD"",
                    ""id"": ""cbeb9585-6d94-4fd1-ac8d-3663c2102897"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""PC<-,->"",
                    ""id"": ""78b32bf9-60d2-48ab-ab22-fa3e0fa87771"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""aac12d1b-aeeb-4c16-b5d3-99a5fac96329"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""95cdf6a8-eb80-4f1a-a1aa-ce69da4fe9ca"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""57541f01-62c4-42d5-9f4a-71f173528449"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamePadStick"",
                    ""id"": ""6bad3e56-edc2-404b-8381-dabaa0aa46a2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""898ae28e-1793-4d55-9241-cee87481c9b8"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8820d122-c614-4628-a73c-9bff167d4bb8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7ab20f69-b79b-43e7-a941-9eecee2e1f3f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad<-,->"",
                    ""id"": ""0413bc45-b933-4983-bf1c-cfc4bf935f54"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""795c3389-f39b-45ff-9bd1-1abfa004962b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dd1fe846-13b2-48c6-9950-92729f63590b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""ad4a19b9-8e0f-480c-af75-0e5babe93f3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""PcAD"",
                    ""id"": ""ed64d382-a2b4-4ace-af3c-5e160ec8862a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""PC<-,->"",
                    ""id"": ""166641a9-9d11-4169-aa7f-581379c3a480"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8d70b467-a7f4-4519-b70f-e503d1846419"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f372b39b-667a-4bc4-9869-714001033725"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""78e05e20-2738-4207-97d4-3c9c550c3d13"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamePadStick"",
                    ""id"": ""e5e92f46-1855-4ba7-a0fa-d6b6210a0383"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""223ad368-a1ce-40e5-bac0-7d9a05671020"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4a5f7ee1-9281-46ce-9b36-33b3743d105d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ed5a0fec-8ed9-46a8-915e-7bd2e6c74bc3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad<-,->"",
                    ""id"": ""4a04f280-e407-4d12-80d7-9813c23091e7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3db2fbea-59c5-4629-bf04-568637a59ec3"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e0e9a248-21f9-4395-8a03-8c37f733312d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""AimPc"",
            ""id"": ""da592005-a4c5-4e25-8c6e-0b4c9160cbd7"",
            ""actions"": [
                {
                    ""name"": ""ActivateAIM"",
                    ""type"": ""Value"",
                    ""id"": ""31617c9b-d588-4aa1-98a6-3b66c6dc81b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""6da2c262-1778-4136-86e5-da313d97b212"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d9429f37-e67e-4b61-a815-16aa22601988"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateAIM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e02cf3a9-405c-453e-b8db-e29a47c40572"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AimConsole"",
            ""id"": ""0229a468-e148-4bed-b8ac-c6317cd34bf2"",
            ""actions"": [
                {
                    ""name"": ""AimConsole"",
                    ""type"": ""Value"",
                    ""id"": ""5792268b-7b6c-4960-89ba-51b39d39f83f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57502a5c-7022-4e32-a90e-d04c977a617b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimConsole"",
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
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
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
        m_MovementSchemeFighting_Shoot = m_MovementSchemeFighting.FindAction("Shoot", throwIfNotFound: true);
        m_MovementSchemeFighting_HorizontalMovement = m_MovementSchemeFighting.FindAction("HorizontalMovement", throwIfNotFound: true);
        // Ui
        m_Ui = asset.FindActionMap("Ui", throwIfNotFound: true);
        m_Ui_Pause = m_Ui.FindAction("Pause", throwIfNotFound: true);
        m_Ui_Exit = m_Ui.FindAction("Exit", throwIfNotFound: true);
        // MovementSchemeNoFighting
        m_MovementSchemeNoFighting = asset.FindActionMap("MovementSchemeNoFighting", throwIfNotFound: true);
        m_MovementSchemeNoFighting_HorizontalMovement = m_MovementSchemeNoFighting.FindAction("HorizontalMovement", throwIfNotFound: true);
        // AimPc
        m_AimPc = asset.FindActionMap("AimPc", throwIfNotFound: true);
        m_AimPc_ActivateAIM = m_AimPc.FindAction("ActivateAIM", throwIfNotFound: true);
        m_AimPc_Aim = m_AimPc.FindAction("Aim", throwIfNotFound: true);
        // AimConsole
        m_AimConsole = asset.FindActionMap("AimConsole", throwIfNotFound: true);
        m_AimConsole_AimConsole = m_AimConsole.FindAction("AimConsole", throwIfNotFound: true);
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
    private readonly InputAction m_MovementSchemeFighting_Shoot;
    private readonly InputAction m_MovementSchemeFighting_HorizontalMovement;
    public struct MovementSchemeFightingActions
    {
        private @CacpRealControlls m_Wrapper;
        public MovementSchemeFightingActions(@CacpRealControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_MovementSchemeFighting_Jump;
        public InputAction @Shoot => m_Wrapper.m_MovementSchemeFighting_Shoot;
        public InputAction @HorizontalMovement => m_Wrapper.m_MovementSchemeFighting_HorizontalMovement;
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
                @Shoot.started -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnShoot;
                @HorizontalMovement.started -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface.OnHorizontalMovement;
            }
            m_Wrapper.m_MovementSchemeFightingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
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
    private readonly InputAction m_MovementSchemeNoFighting_HorizontalMovement;
    public struct MovementSchemeNoFightingActions
    {
        private @CacpRealControlls m_Wrapper;
        public MovementSchemeNoFightingActions(@CacpRealControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_MovementSchemeNoFighting_HorizontalMovement;
        public InputActionMap Get() { return m_Wrapper.m_MovementSchemeNoFighting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementSchemeNoFightingActions set) { return set.Get(); }
        public void SetCallbacks(IMovementSchemeNoFightingActions instance)
        {
            if (m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface.OnHorizontalMovement;
            }
            m_Wrapper.m_MovementSchemeNoFightingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
            }
        }
    }
    public MovementSchemeNoFightingActions @MovementSchemeNoFighting => new MovementSchemeNoFightingActions(this);

    // AimPc
    private readonly InputActionMap m_AimPc;
    private IAimPcActions m_AimPcActionsCallbackInterface;
    private readonly InputAction m_AimPc_ActivateAIM;
    private readonly InputAction m_AimPc_Aim;
    public struct AimPcActions
    {
        private @CacpRealControlls m_Wrapper;
        public AimPcActions(@CacpRealControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ActivateAIM => m_Wrapper.m_AimPc_ActivateAIM;
        public InputAction @Aim => m_Wrapper.m_AimPc_Aim;
        public InputActionMap Get() { return m_Wrapper.m_AimPc; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AimPcActions set) { return set.Get(); }
        public void SetCallbacks(IAimPcActions instance)
        {
            if (m_Wrapper.m_AimPcActionsCallbackInterface != null)
            {
                @ActivateAIM.started -= m_Wrapper.m_AimPcActionsCallbackInterface.OnActivateAIM;
                @ActivateAIM.performed -= m_Wrapper.m_AimPcActionsCallbackInterface.OnActivateAIM;
                @ActivateAIM.canceled -= m_Wrapper.m_AimPcActionsCallbackInterface.OnActivateAIM;
                @Aim.started -= m_Wrapper.m_AimPcActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_AimPcActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_AimPcActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_AimPcActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ActivateAIM.started += instance.OnActivateAIM;
                @ActivateAIM.performed += instance.OnActivateAIM;
                @ActivateAIM.canceled += instance.OnActivateAIM;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public AimPcActions @AimPc => new AimPcActions(this);

    // AimConsole
    private readonly InputActionMap m_AimConsole;
    private IAimConsoleActions m_AimConsoleActionsCallbackInterface;
    private readonly InputAction m_AimConsole_AimConsole;
    public struct AimConsoleActions
    {
        private @CacpRealControlls m_Wrapper;
        public AimConsoleActions(@CacpRealControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @AimConsole => m_Wrapper.m_AimConsole_AimConsole;
        public InputActionMap Get() { return m_Wrapper.m_AimConsole; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AimConsoleActions set) { return set.Get(); }
        public void SetCallbacks(IAimConsoleActions instance)
        {
            if (m_Wrapper.m_AimConsoleActionsCallbackInterface != null)
            {
                @AimConsole.started -= m_Wrapper.m_AimConsoleActionsCallbackInterface.OnAimConsole;
                @AimConsole.performed -= m_Wrapper.m_AimConsoleActionsCallbackInterface.OnAimConsole;
                @AimConsole.canceled -= m_Wrapper.m_AimConsoleActionsCallbackInterface.OnAimConsole;
            }
            m_Wrapper.m_AimConsoleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AimConsole.started += instance.OnAimConsole;
                @AimConsole.performed += instance.OnAimConsole;
                @AimConsole.canceled += instance.OnAimConsole;
            }
        }
    }
    public AimConsoleActions @AimConsole => new AimConsoleActions(this);
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
        void OnShoot(InputAction.CallbackContext context);
        void OnHorizontalMovement(InputAction.CallbackContext context);
    }
    public interface IUiActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IMovementSchemeNoFightingActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
    }
    public interface IAimPcActions
    {
        void OnActivateAIM(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
    public interface IAimConsoleActions
    {
        void OnAimConsole(InputAction.CallbackContext context);
    }
}
