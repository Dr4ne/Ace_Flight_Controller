// GENERATED AUTOMATICALLY FROM 'Assets/_Scripts/Ace_Input_Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Ace_Input_Actions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Ace_Input_Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Ace_Input_Actions"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""ed88edb3-fcd3-4818-b6f7-ba1e6f2bd014"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8ef9b6f1-28e5-440e-be15-56d6b9b9e914"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer Delta"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7250f85d-142c-4bba-85ce-38408124e684"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""ScaleVector2(x=0.5,y=0.5)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer MousePos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""db83d473-cdad-49f3-a35e-7b01913b6fd8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Unlock"",
                    ""type"": ""Button"",
                    ""id"": ""e8c31beb-e78f-4cb7-baa4-16edc3b347de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer Velocity link switch"",
                    ""type"": ""Button"",
                    ""id"": ""a2f7929c-df89-4305-8bb6-cc674cbfbde6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""719e4a80-5e76-40fc-9019-e691053d779c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a6dd3548-dfb0-4311-9625-8f53427b5c9c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b2b5b2c4-b757-4c5f-a970-fc5f2f9af9c0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""69138925-c9bf-4079-bdb0-caf23e40f550"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""18a73b37-2b1b-480a-a306-c8bb11c5cf0c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d11aa952-976a-48e2-9ab7-f478e88afec0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5987fd90-70fe-4955-af16-d0e0e7264103"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6e5f8672-f0b5-4ade-82ea-a15e29405526"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c057b9a4-332d-436f-8357-8e54b1b46dd3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left_Stick"",
                    ""id"": ""ab13b8da-fd0d-4433-ac86-31e8113f489b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6e7cf9c5-e4c3-4f92-b575-6a7ea22a7439"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""26465872-e51f-47b6-994b-6942b4d7efad"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""61caaf66-a838-4ace-9007-906d3646d827"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""50fada91-fac1-4e80-9d78-588714168d6b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""91d56a41-547a-4034-9e76-493e8a274e37"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Steer Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da4b7146-138c-465f-a3e3-c3e4e6f34068"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Steer MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd0ae064-88da-419f-9bea-3401ce5e3766"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Unlock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50a62ee9-fc25-4131-8f53-cd36f77d9edf"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": ""Press(pressPoint=1,behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Steer Velocity link switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
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
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerControls_SteerDelta = m_PlayerControls.FindAction("Steer Delta", throwIfNotFound: true);
        m_PlayerControls_SteerMousePos = m_PlayerControls.FindAction("Steer MousePos", throwIfNotFound: true);
        m_PlayerControls_Unlock = m_PlayerControls.FindAction("Unlock", throwIfNotFound: true);
        m_PlayerControls_SteerVelocitylinkswitch = m_PlayerControls.FindAction("Steer Velocity link switch", throwIfNotFound: true);
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

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Move;
    private readonly InputAction m_PlayerControls_SteerDelta;
    private readonly InputAction m_PlayerControls_SteerMousePos;
    private readonly InputAction m_PlayerControls_Unlock;
    private readonly InputAction m_PlayerControls_SteerVelocitylinkswitch;
    public struct PlayerControlsActions
    {
        private @Ace_Input_Actions m_Wrapper;
        public PlayerControlsActions(@Ace_Input_Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputAction @SteerDelta => m_Wrapper.m_PlayerControls_SteerDelta;
        public InputAction @SteerMousePos => m_Wrapper.m_PlayerControls_SteerMousePos;
        public InputAction @Unlock => m_Wrapper.m_PlayerControls_Unlock;
        public InputAction @SteerVelocitylinkswitch => m_Wrapper.m_PlayerControls_SteerVelocitylinkswitch;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @SteerDelta.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSteerDelta;
                @SteerDelta.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSteerDelta;
                @SteerDelta.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSteerDelta;
                @SteerMousePos.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSteerMousePos;
                @SteerMousePos.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSteerMousePos;
                @SteerMousePos.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSteerMousePos;
                @Unlock.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUnlock;
                @Unlock.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUnlock;
                @Unlock.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUnlock;
                @SteerVelocitylinkswitch.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSteerVelocitylinkswitch;
                @SteerVelocitylinkswitch.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSteerVelocitylinkswitch;
                @SteerVelocitylinkswitch.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSteerVelocitylinkswitch;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @SteerDelta.started += instance.OnSteerDelta;
                @SteerDelta.performed += instance.OnSteerDelta;
                @SteerDelta.canceled += instance.OnSteerDelta;
                @SteerMousePos.started += instance.OnSteerMousePos;
                @SteerMousePos.performed += instance.OnSteerMousePos;
                @SteerMousePos.canceled += instance.OnSteerMousePos;
                @Unlock.started += instance.OnUnlock;
                @Unlock.performed += instance.OnUnlock;
                @Unlock.canceled += instance.OnUnlock;
                @SteerVelocitylinkswitch.started += instance.OnSteerVelocitylinkswitch;
                @SteerVelocitylinkswitch.performed += instance.OnSteerVelocitylinkswitch;
                @SteerVelocitylinkswitch.canceled += instance.OnSteerVelocitylinkswitch;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSteerDelta(InputAction.CallbackContext context);
        void OnSteerMousePos(InputAction.CallbackContext context);
        void OnUnlock(InputAction.CallbackContext context);
        void OnSteerVelocitylinkswitch(InputAction.CallbackContext context);
    }
}
