//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Player/Input/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerActionmap"",
            ""id"": ""91440ac8-602a-47c4-ba6a-32998db8a950"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""507e43fd-f7a7-44b0-bf20-ce84e41f6f27"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""61ed9cdf-f09a-410d-a9b6-9a1f89da2d69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""Value"",
                    ""id"": ""c1614878-8f19-49f9-9cf4-d444f6899bbf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fa855ef7-43a3-4dea-8728-955792cc414c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""55268dd5-6b70-4ad8-8ff8-947dcba59d0d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""051513f0-90f5-410c-9af2-e60d12dc6d96"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7de441b7-5173-4861-8f6f-c7dbe73e7294"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bba0a43f-4b37-4c4e-9237-81fb6d86c60e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4e2d56d4-a3e8-43a7-8ad7-1c1322e751be"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""742e90f7-d31d-444a-a1f0-7f22ce5112f4"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PlayerControls"",
            ""bindingGroup"": ""PlayerControls"",
            ""devices"": []
        }
    ]
}");
        // PlayerActionmap
        m_PlayerActionmap = asset.FindActionMap("PlayerActionmap", throwIfNotFound: true);
        m_PlayerActionmap_Movement = m_PlayerActionmap.FindAction("Movement", throwIfNotFound: true);
        m_PlayerActionmap_Jump = m_PlayerActionmap.FindAction("Jump", throwIfNotFound: true);
        m_PlayerActionmap_MouseLook = m_PlayerActionmap.FindAction("MouseLook", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerActionmap
    private readonly InputActionMap m_PlayerActionmap;
    private IPlayerActionmapActions m_PlayerActionmapActionsCallbackInterface;
    private readonly InputAction m_PlayerActionmap_Movement;
    private readonly InputAction m_PlayerActionmap_Jump;
    private readonly InputAction m_PlayerActionmap_MouseLook;
    public struct PlayerActionmapActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActionmapActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerActionmap_Movement;
        public InputAction @Jump => m_Wrapper.m_PlayerActionmap_Jump;
        public InputAction @MouseLook => m_Wrapper.m_PlayerActionmap_MouseLook;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionmapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionmapActions instance)
        {
            if (m_Wrapper.m_PlayerActionmapActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionmapActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionmapActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionmapActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerActionmapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionmapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionmapActionsCallbackInterface.OnJump;
                @MouseLook.started -= m_Wrapper.m_PlayerActionmapActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_PlayerActionmapActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_PlayerActionmapActionsCallbackInterface.OnMouseLook;
            }
            m_Wrapper.m_PlayerActionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
            }
        }
    }
    public PlayerActionmapActions @PlayerActionmap => new PlayerActionmapActions(this);
    private int m_PlayerControlsSchemeIndex = -1;
    public InputControlScheme PlayerControlsScheme
    {
        get
        {
            if (m_PlayerControlsSchemeIndex == -1) m_PlayerControlsSchemeIndex = asset.FindControlSchemeIndex("PlayerControls");
            return asset.controlSchemes[m_PlayerControlsSchemeIndex];
        }
    }
    public interface IPlayerActionmapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseLook(InputAction.CallbackContext context);
    }
}
