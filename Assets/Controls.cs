// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5b60b031-1aa3-421a-b1d9-5157aa199246"",
            ""actions"": [
                {
                    ""name"": ""PrimaryActiveSkill"",
                    ""type"": ""Button"",
                    ""id"": ""cdcc80aa-bf91-4464-947c-695a18592f30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9c8bf289-c35a-40c0-9c14-35a79308c83a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RHand"",
                    ""type"": ""Button"",
                    ""id"": ""f75a764a-a213-4d58-8637-3e15d6f9f7e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LHand"",
                    ""type"": ""Button"",
                    ""id"": ""37f04d89-93c5-4098-9589-45c934973fdf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""74b8512c-f65d-416c-b8a2-bd62f81ed7fe"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryActiveSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""68cafd3f-bbbe-4c99-ba93-cc31edad7104"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""526ba88b-c83b-4842-b425-134ef386650c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b4c1d030-3a4b-4e67-9a4c-4fd87c5e8db9"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""16ec9b10-d488-4303-9178-19778424b0c5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d184444f-cb83-4139-9315-5974fb865a6d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""371e9ad1-593e-4ce5-a8f5-6ed789607a70"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d1f2608-2e2a-4b1f-a747-c097e64b72e8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_PrimaryActiveSkill = m_Player.FindAction("PrimaryActiveSkill", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_RHand = m_Player.FindAction("RHand", throwIfNotFound: true);
        m_Player_LHand = m_Player.FindAction("LHand", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_PrimaryActiveSkill;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_RHand;
    private readonly InputAction m_Player_LHand;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryActiveSkill => m_Wrapper.m_Player_PrimaryActiveSkill;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @RHand => m_Wrapper.m_Player_RHand;
        public InputAction @LHand => m_Wrapper.m_Player_LHand;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @PrimaryActiveSkill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimaryActiveSkill;
                @PrimaryActiveSkill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimaryActiveSkill;
                @PrimaryActiveSkill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimaryActiveSkill;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @RHand.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRHand;
                @RHand.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRHand;
                @RHand.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRHand;
                @LHand.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLHand;
                @LHand.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLHand;
                @LHand.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLHand;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryActiveSkill.started += instance.OnPrimaryActiveSkill;
                @PrimaryActiveSkill.performed += instance.OnPrimaryActiveSkill;
                @PrimaryActiveSkill.canceled += instance.OnPrimaryActiveSkill;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RHand.started += instance.OnRHand;
                @RHand.performed += instance.OnRHand;
                @RHand.canceled += instance.OnRHand;
                @LHand.started += instance.OnLHand;
                @LHand.performed += instance.OnLHand;
                @LHand.canceled += instance.OnLHand;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnPrimaryActiveSkill(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRHand(InputAction.CallbackContext context);
        void OnLHand(InputAction.CallbackContext context);
    }
}
