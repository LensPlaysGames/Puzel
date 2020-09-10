// GENERATED AUTOMATICALLY FROM 'Assets/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""playerSwitch"",
            ""id"": ""5cad693a-2a3c-413b-8061-3c7e35bda6bd"",
            ""actions"": [
                {
                    ""name"": ""selectRedPlayer"",
                    ""type"": ""Button"",
                    ""id"": ""6383466e-0258-40f2-9ea8-70b8eef577f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""selectGreenPlayer"",
                    ""type"": ""Button"",
                    ""id"": ""918b5f72-1943-4412-becb-15b7d5fdbacd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""selectBluePlayer"",
                    ""type"": ""Button"",
                    ""id"": ""39ede9a3-fdd0-4b01-b2ee-971f36d63ef1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cfedc12a-42f5-47ea-994e-72dc2366a862"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""selectRedPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2bd4fe0-919c-4370-8ce5-60e22d768507"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""selectGreenPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6807ad0e-e2bb-49fb-94d3-40fb90019f99"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""selectBluePlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""player"",
            ""id"": ""93330eb2-5d57-4967-9871-7844f5b362dd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e61051d2-d65d-40ca-bdb0-379a661797b3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""63941eba-a197-4e8c-8362-2749fa9d1641"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""54964fe9-ba1e-47e3-9f27-898fc4eacd47"",
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
                    ""id"": ""4309645e-5037-4c70-ab8e-16a21c1e3229"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""63f069b5-c10c-4753-9850-30d127698925"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftRight"",
                    ""id"": ""eca21330-7b30-4686-be20-1e27db30c99b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7f8ded5a-71f9-4492-b310-6e5301896e9d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""83f2c53a-f5a3-482a-8eb6-27ca5f27c7a7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bb7c57e5-89d5-4198-bfc4-2b93022295a8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70b2a090-49b8-4068-b0e9-5df6d8b07ad0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kb & M"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Kb & M"",
            ""bindingGroup"": ""Kb & M"",
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
        }
    ]
}");
        // playerSwitch
        m_playerSwitch = asset.FindActionMap("playerSwitch", throwIfNotFound: true);
        m_playerSwitch_selectRedPlayer = m_playerSwitch.FindAction("selectRedPlayer", throwIfNotFound: true);
        m_playerSwitch_selectGreenPlayer = m_playerSwitch.FindAction("selectGreenPlayer", throwIfNotFound: true);
        m_playerSwitch_selectBluePlayer = m_playerSwitch.FindAction("selectBluePlayer", throwIfNotFound: true);
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_Movement = m_player.FindAction("Movement", throwIfNotFound: true);
        m_player_Jump = m_player.FindAction("Jump", throwIfNotFound: true);
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

    // playerSwitch
    private readonly InputActionMap m_playerSwitch;
    private IPlayerSwitchActions m_PlayerSwitchActionsCallbackInterface;
    private readonly InputAction m_playerSwitch_selectRedPlayer;
    private readonly InputAction m_playerSwitch_selectGreenPlayer;
    private readonly InputAction m_playerSwitch_selectBluePlayer;
    public struct PlayerSwitchActions
    {
        private @InputManager m_Wrapper;
        public PlayerSwitchActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @selectRedPlayer => m_Wrapper.m_playerSwitch_selectRedPlayer;
        public InputAction @selectGreenPlayer => m_Wrapper.m_playerSwitch_selectGreenPlayer;
        public InputAction @selectBluePlayer => m_Wrapper.m_playerSwitch_selectBluePlayer;
        public InputActionMap Get() { return m_Wrapper.m_playerSwitch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerSwitchActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerSwitchActions instance)
        {
            if (m_Wrapper.m_PlayerSwitchActionsCallbackInterface != null)
            {
                @selectRedPlayer.started -= m_Wrapper.m_PlayerSwitchActionsCallbackInterface.OnSelectRedPlayer;
                @selectRedPlayer.performed -= m_Wrapper.m_PlayerSwitchActionsCallbackInterface.OnSelectRedPlayer;
                @selectRedPlayer.canceled -= m_Wrapper.m_PlayerSwitchActionsCallbackInterface.OnSelectRedPlayer;
                @selectGreenPlayer.started -= m_Wrapper.m_PlayerSwitchActionsCallbackInterface.OnSelectGreenPlayer;
                @selectGreenPlayer.performed -= m_Wrapper.m_PlayerSwitchActionsCallbackInterface.OnSelectGreenPlayer;
                @selectGreenPlayer.canceled -= m_Wrapper.m_PlayerSwitchActionsCallbackInterface.OnSelectGreenPlayer;
                @selectBluePlayer.started -= m_Wrapper.m_PlayerSwitchActionsCallbackInterface.OnSelectBluePlayer;
                @selectBluePlayer.performed -= m_Wrapper.m_PlayerSwitchActionsCallbackInterface.OnSelectBluePlayer;
                @selectBluePlayer.canceled -= m_Wrapper.m_PlayerSwitchActionsCallbackInterface.OnSelectBluePlayer;
            }
            m_Wrapper.m_PlayerSwitchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @selectRedPlayer.started += instance.OnSelectRedPlayer;
                @selectRedPlayer.performed += instance.OnSelectRedPlayer;
                @selectRedPlayer.canceled += instance.OnSelectRedPlayer;
                @selectGreenPlayer.started += instance.OnSelectGreenPlayer;
                @selectGreenPlayer.performed += instance.OnSelectGreenPlayer;
                @selectGreenPlayer.canceled += instance.OnSelectGreenPlayer;
                @selectBluePlayer.started += instance.OnSelectBluePlayer;
                @selectBluePlayer.performed += instance.OnSelectBluePlayer;
                @selectBluePlayer.canceled += instance.OnSelectBluePlayer;
            }
        }
    }
    public PlayerSwitchActions @playerSwitch => new PlayerSwitchActions(this);

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_Movement;
    private readonly InputAction m_player_Jump;
    public struct PlayerActions
    {
        private @InputManager m_Wrapper;
        public PlayerActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_player_Movement;
        public InputAction @Jump => m_Wrapper.m_player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    private int m_KbMSchemeIndex = -1;
    public InputControlScheme KbMScheme
    {
        get
        {
            if (m_KbMSchemeIndex == -1) m_KbMSchemeIndex = asset.FindControlSchemeIndex("Kb & M");
            return asset.controlSchemes[m_KbMSchemeIndex];
        }
    }
    public interface IPlayerSwitchActions
    {
        void OnSelectRedPlayer(InputAction.CallbackContext context);
        void OnSelectGreenPlayer(InputAction.CallbackContext context);
        void OnSelectBluePlayer(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
