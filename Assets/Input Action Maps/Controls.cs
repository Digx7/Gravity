// GENERATED AUTOMATICALLY FROM 'Assets/Input Action Maps/Controls.inputactions'

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
            ""name"": ""ZeroGShip"",
            ""id"": ""99870d2d-225b-47db-ade6-29ad33b3f8ca"",
            ""actions"": [
                {
                    ""name"": ""RotateXYaxis"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8cbd541b-cdd0-4d15-9ce4-5b2e6b94063c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveXYaxis"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7ad50a13-22f4-4d2b-a0a1-fc9ed8ceff0e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveZaxis"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ae3a71ca-a720-42d4-a176-5e9b5cf503fa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateZaxis"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8cba481a-c3ca-4604-a45f-48b650898638"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RadarDistance"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aa98fd5d-c8e6-4fa0-9c26-7a64d30c75b7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""be1f5a23-7bb9-4173-8ad3-18dbae97cb8b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateXYaxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4e20f042-0f4c-4bce-bb5b-ca6cd363645e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""RotateXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""732a0708-d824-4c42-890f-fe034b6d4520"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""RotateXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e8db7cbb-fbfd-4761-9737-0de38aa545fd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""RotateXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f15a0402-df91-4593-9296-54f2f6f01cab"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""RotateXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b21a9aba-84cb-4818-9fb2-582ec1c965d0"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controler"",
                    ""action"": ""RotateXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""9640ff70-65b5-4939-8dcf-55d14fea9bbe"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveXYaxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e53a372f-259d-4ade-933a-48c19f473ecb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""MoveXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7b453617-de7e-4e1e-ba5c-a3766dd44fd1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""MoveXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""21e88b03-fb82-48c7-aaf1-c659f28885a9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""MoveXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""89ca6d4a-2143-4184-b766-f50eb2bf5a27"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""MoveXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fbd14442-b1ca-434c-897c-e72f0d039b14"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controler"",
                    ""action"": ""MoveXYaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""EQ"",
                    ""id"": ""60792020-8f52-43d1-8d2f-b6ee071946cb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZaxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b7d1b9b8-30d2-42a2-8942-db395ae779dd"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""MoveZaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""18023a4d-a95d-441a-bd09-c27d4dfd6b74"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""MoveZaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Bumpers"",
                    ""id"": ""e227e798-ebd4-4749-944d-c35fe764818b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZaxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1de66f69-3668-4aa7-94d2-fffd3d1a0f11"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controler"",
                    ""action"": ""MoveZaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b6ff995b-baca-49f5-966d-77c6893614cb"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controler"",
                    ""action"": ""MoveZaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift/Control"",
                    ""id"": ""a94117aa-fb57-48d8-b30b-8fbec8932c63"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateZaxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a7e68714-3616-41e6-a525-464f87476233"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""RotateZaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8cbb0147-e492-4999-87ed-6448bd78385b"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""RotateZaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shoulders"",
                    ""id"": ""7c544ae2-4bea-417e-ba69-a26e20021bd2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateZaxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f8cf9bce-399f-4559-bd3b-96d3a76c5cbc"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controler"",
                    ""action"": ""RotateZaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""456517cb-7b96-46ca-97b6-8c2e33d8a897"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controler"",
                    ""action"": ""RotateZaxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-pad"",
                    ""id"": ""9fa24851-b0e0-4ce9-ab6c-0704b22f11c3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RadarDistance"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""474ba050-34ed-4291-9f14-c48581f9c163"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controler"",
                    ""action"": ""RadarDistance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3152ad49-6634-4a42-9ab3-f7844c2b14d3"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controler"",
                    ""action"": ""RadarDistance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard/Mouse"",
            ""bindingGroup"": ""Keyboard/Mouse"",
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
            ""name"": ""Controler"",
            ""bindingGroup"": ""Controler"",
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
        // ZeroGShip
        m_ZeroGShip = asset.FindActionMap("ZeroGShip", throwIfNotFound: true);
        m_ZeroGShip_RotateXYaxis = m_ZeroGShip.FindAction("RotateXYaxis", throwIfNotFound: true);
        m_ZeroGShip_MoveXYaxis = m_ZeroGShip.FindAction("MoveXYaxis", throwIfNotFound: true);
        m_ZeroGShip_MoveZaxis = m_ZeroGShip.FindAction("MoveZaxis", throwIfNotFound: true);
        m_ZeroGShip_RotateZaxis = m_ZeroGShip.FindAction("RotateZaxis", throwIfNotFound: true);
        m_ZeroGShip_RadarDistance = m_ZeroGShip.FindAction("RadarDistance", throwIfNotFound: true);
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

    // ZeroGShip
    private readonly InputActionMap m_ZeroGShip;
    private IZeroGShipActions m_ZeroGShipActionsCallbackInterface;
    private readonly InputAction m_ZeroGShip_RotateXYaxis;
    private readonly InputAction m_ZeroGShip_MoveXYaxis;
    private readonly InputAction m_ZeroGShip_MoveZaxis;
    private readonly InputAction m_ZeroGShip_RotateZaxis;
    private readonly InputAction m_ZeroGShip_RadarDistance;
    public struct ZeroGShipActions
    {
        private @Controls m_Wrapper;
        public ZeroGShipActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateXYaxis => m_Wrapper.m_ZeroGShip_RotateXYaxis;
        public InputAction @MoveXYaxis => m_Wrapper.m_ZeroGShip_MoveXYaxis;
        public InputAction @MoveZaxis => m_Wrapper.m_ZeroGShip_MoveZaxis;
        public InputAction @RotateZaxis => m_Wrapper.m_ZeroGShip_RotateZaxis;
        public InputAction @RadarDistance => m_Wrapper.m_ZeroGShip_RadarDistance;
        public InputActionMap Get() { return m_Wrapper.m_ZeroGShip; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ZeroGShipActions set) { return set.Get(); }
        public void SetCallbacks(IZeroGShipActions instance)
        {
            if (m_Wrapper.m_ZeroGShipActionsCallbackInterface != null)
            {
                @RotateXYaxis.started -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnRotateXYaxis;
                @RotateXYaxis.performed -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnRotateXYaxis;
                @RotateXYaxis.canceled -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnRotateXYaxis;
                @MoveXYaxis.started -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnMoveXYaxis;
                @MoveXYaxis.performed -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnMoveXYaxis;
                @MoveXYaxis.canceled -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnMoveXYaxis;
                @MoveZaxis.started -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnMoveZaxis;
                @MoveZaxis.performed -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnMoveZaxis;
                @MoveZaxis.canceled -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnMoveZaxis;
                @RotateZaxis.started -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnRotateZaxis;
                @RotateZaxis.performed -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnRotateZaxis;
                @RotateZaxis.canceled -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnRotateZaxis;
                @RadarDistance.started -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnRadarDistance;
                @RadarDistance.performed -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnRadarDistance;
                @RadarDistance.canceled -= m_Wrapper.m_ZeroGShipActionsCallbackInterface.OnRadarDistance;
            }
            m_Wrapper.m_ZeroGShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateXYaxis.started += instance.OnRotateXYaxis;
                @RotateXYaxis.performed += instance.OnRotateXYaxis;
                @RotateXYaxis.canceled += instance.OnRotateXYaxis;
                @MoveXYaxis.started += instance.OnMoveXYaxis;
                @MoveXYaxis.performed += instance.OnMoveXYaxis;
                @MoveXYaxis.canceled += instance.OnMoveXYaxis;
                @MoveZaxis.started += instance.OnMoveZaxis;
                @MoveZaxis.performed += instance.OnMoveZaxis;
                @MoveZaxis.canceled += instance.OnMoveZaxis;
                @RotateZaxis.started += instance.OnRotateZaxis;
                @RotateZaxis.performed += instance.OnRotateZaxis;
                @RotateZaxis.canceled += instance.OnRotateZaxis;
                @RadarDistance.started += instance.OnRadarDistance;
                @RadarDistance.performed += instance.OnRadarDistance;
                @RadarDistance.canceled += instance.OnRadarDistance;
            }
        }
    }
    public ZeroGShipActions @ZeroGShip => new ZeroGShipActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard/Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_ControlerSchemeIndex = -1;
    public InputControlScheme ControlerScheme
    {
        get
        {
            if (m_ControlerSchemeIndex == -1) m_ControlerSchemeIndex = asset.FindControlSchemeIndex("Controler");
            return asset.controlSchemes[m_ControlerSchemeIndex];
        }
    }
    public interface IZeroGShipActions
    {
        void OnRotateXYaxis(InputAction.CallbackContext context);
        void OnMoveXYaxis(InputAction.CallbackContext context);
        void OnMoveZaxis(InputAction.CallbackContext context);
        void OnRotateZaxis(InputAction.CallbackContext context);
        void OnRadarDistance(InputAction.CallbackContext context);
    }
}
