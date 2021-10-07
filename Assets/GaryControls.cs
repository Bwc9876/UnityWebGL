// GENERATED AUTOMATICALLY FROM 'Assets/GaryControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GaryControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GaryControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GaryControls"",
    ""maps"": [
        {
            ""name"": ""Gary"",
            ""id"": ""24ea6d78-fce7-483f-990d-d6f7d3442758"",
            ""actions"": [
                {
                    ""name"": ""Flip"",
                    ""type"": ""Button"",
                    ""id"": ""4d167a4b-4278-4883-8faa-e4e0a67e5c1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2c1cba79-1ac9-4f95-86ae-9519301e42bc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""841fdaa8-b694-4ffb-b962-8b892780b921"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dafa3e7a-3a0b-4e51-b918-f4b64fc2cefd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gary
        m_Gary = asset.FindActionMap("Gary", throwIfNotFound: true);
        m_Gary_Flip = m_Gary.FindAction("Flip", throwIfNotFound: true);
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

    // Gary
    private readonly InputActionMap m_Gary;
    private IGaryActions m_GaryActionsCallbackInterface;
    private readonly InputAction m_Gary_Flip;
    public struct GaryActions
    {
        private @GaryControls m_Wrapper;
        public GaryActions(@GaryControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Flip => m_Wrapper.m_Gary_Flip;
        public InputActionMap Get() { return m_Wrapper.m_Gary; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GaryActions set) { return set.Get(); }
        public void SetCallbacks(IGaryActions instance)
        {
            if (m_Wrapper.m_GaryActionsCallbackInterface != null)
            {
                @Flip.started -= m_Wrapper.m_GaryActionsCallbackInterface.OnFlip;
                @Flip.performed -= m_Wrapper.m_GaryActionsCallbackInterface.OnFlip;
                @Flip.canceled -= m_Wrapper.m_GaryActionsCallbackInterface.OnFlip;
            }
            m_Wrapper.m_GaryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Flip.started += instance.OnFlip;
                @Flip.performed += instance.OnFlip;
                @Flip.canceled += instance.OnFlip;
            }
        }
    }
    public GaryActions @Gary => new GaryActions(this);
    public interface IGaryActions
    {
        void OnFlip(InputAction.CallbackContext context);
    }
}
