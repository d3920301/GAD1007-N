//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Jousting"",
            ""id"": ""84f264fa-9e58-4bc2-955b-8922b4618706"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""eeb52075-27d4-4027-b9f7-49f9d6c58308"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PowerBar"",
                    ""type"": ""Value"",
                    ""id"": ""c86f9c96-836e-4528-b3e8-b2b6b9f28fc3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""KB&M 1D Axis"",
                    ""id"": ""b14effad-2b95-4100-912b-0668f41db943"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""69c4a4a2-db07-4859-9836-71493ef4c03d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""169b65bb-5b2b-4d92-b62f-c1cd73c98b13"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Stick 1D Axis"",
                    ""id"": ""207c09b2-ae45-4c91-be61-38fc519ae36c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6d9f0bf5-cb31-4da7-8cc9-82d403346934"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e4986cdf-39fa-4192-8963-a5316eb6b545"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad 1D Axis"",
                    ""id"": ""bdae743f-2d1b-4763-a848-01d3d199b2be"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5af69dc2-20db-4607-9084-c7ffbe38065b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5852183b-ce85-4e61-bbf9-a8e8701cb775"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5e3931ed-a97f-4385-979e-360e22f3c1ec"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PowerBar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ede69be-cc16-4435-94a3-03ef19eed35f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PowerBar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Cheats"",
            ""id"": ""1c6df04c-1103-4c5e-98a0-85edbc9a9935"",
            ""actions"": [
                {
                    ""name"": ""NextRound"",
                    ""type"": ""Button"",
                    ""id"": ""3b262154-e629-4785-a59e-3f016c2945a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6576984e-4f67-4c0c-b040-e288ddccbc90"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""NextRound"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Town"",
            ""id"": ""1fca606a-dcb3-47cf-8377-c24a827021be"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""80338c67-9a45-4e72-8497-4c2929552cee"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0250b796-7141-42bb-bbfa-8a9fb1c2a3fc"",
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
                    ""id"": ""daee1b0e-35bb-4fdb-9414-36bde11f1dad"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c451f534-0202-4172-9229-1d6d13ca90ec"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""86dd67bd-13e2-402f-89f7-219e2a0c7f47"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bffee50b-4f46-4b2e-959c-c5188210511e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
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
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Jousting
        m_Jousting = asset.FindActionMap("Jousting", throwIfNotFound: true);
        m_Jousting_Move = m_Jousting.FindAction("Move", throwIfNotFound: true);
        m_Jousting_PowerBar = m_Jousting.FindAction("PowerBar", throwIfNotFound: true);
        // Cheats
        m_Cheats = asset.FindActionMap("Cheats", throwIfNotFound: true);
        m_Cheats_NextRound = m_Cheats.FindAction("NextRound", throwIfNotFound: true);
        // Town
        m_Town = asset.FindActionMap("Town", throwIfNotFound: true);
        m_Town_Move = m_Town.FindAction("Move", throwIfNotFound: true);
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

    // Jousting
    private readonly InputActionMap m_Jousting;
    private List<IJoustingActions> m_JoustingActionsCallbackInterfaces = new List<IJoustingActions>();
    private readonly InputAction m_Jousting_Move;
    private readonly InputAction m_Jousting_PowerBar;
    public struct JoustingActions
    {
        private @PlayerInputActions m_Wrapper;
        public JoustingActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Jousting_Move;
        public InputAction @PowerBar => m_Wrapper.m_Jousting_PowerBar;
        public InputActionMap Get() { return m_Wrapper.m_Jousting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JoustingActions set) { return set.Get(); }
        public void AddCallbacks(IJoustingActions instance)
        {
            if (instance == null || m_Wrapper.m_JoustingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_JoustingActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @PowerBar.started += instance.OnPowerBar;
            @PowerBar.performed += instance.OnPowerBar;
            @PowerBar.canceled += instance.OnPowerBar;
        }

        private void UnregisterCallbacks(IJoustingActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @PowerBar.started -= instance.OnPowerBar;
            @PowerBar.performed -= instance.OnPowerBar;
            @PowerBar.canceled -= instance.OnPowerBar;
        }

        public void RemoveCallbacks(IJoustingActions instance)
        {
            if (m_Wrapper.m_JoustingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IJoustingActions instance)
        {
            foreach (var item in m_Wrapper.m_JoustingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_JoustingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public JoustingActions @Jousting => new JoustingActions(this);

    // Cheats
    private readonly InputActionMap m_Cheats;
    private List<ICheatsActions> m_CheatsActionsCallbackInterfaces = new List<ICheatsActions>();
    private readonly InputAction m_Cheats_NextRound;
    public struct CheatsActions
    {
        private @PlayerInputActions m_Wrapper;
        public CheatsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextRound => m_Wrapper.m_Cheats_NextRound;
        public InputActionMap Get() { return m_Wrapper.m_Cheats; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CheatsActions set) { return set.Get(); }
        public void AddCallbacks(ICheatsActions instance)
        {
            if (instance == null || m_Wrapper.m_CheatsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CheatsActionsCallbackInterfaces.Add(instance);
            @NextRound.started += instance.OnNextRound;
            @NextRound.performed += instance.OnNextRound;
            @NextRound.canceled += instance.OnNextRound;
        }

        private void UnregisterCallbacks(ICheatsActions instance)
        {
            @NextRound.started -= instance.OnNextRound;
            @NextRound.performed -= instance.OnNextRound;
            @NextRound.canceled -= instance.OnNextRound;
        }

        public void RemoveCallbacks(ICheatsActions instance)
        {
            if (m_Wrapper.m_CheatsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICheatsActions instance)
        {
            foreach (var item in m_Wrapper.m_CheatsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CheatsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CheatsActions @Cheats => new CheatsActions(this);

    // Town
    private readonly InputActionMap m_Town;
    private List<ITownActions> m_TownActionsCallbackInterfaces = new List<ITownActions>();
    private readonly InputAction m_Town_Move;
    public struct TownActions
    {
        private @PlayerInputActions m_Wrapper;
        public TownActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Town_Move;
        public InputActionMap Get() { return m_Wrapper.m_Town; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TownActions set) { return set.Get(); }
        public void AddCallbacks(ITownActions instance)
        {
            if (instance == null || m_Wrapper.m_TownActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TownActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(ITownActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(ITownActions instance)
        {
            if (m_Wrapper.m_TownActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITownActions instance)
        {
            foreach (var item in m_Wrapper.m_TownActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TownActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TownActions @Town => new TownActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IJoustingActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPowerBar(InputAction.CallbackContext context);
    }
    public interface ICheatsActions
    {
        void OnNextRound(InputAction.CallbackContext context);
    }
    public interface ITownActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
