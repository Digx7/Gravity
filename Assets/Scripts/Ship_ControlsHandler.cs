using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_ControlsHandler : MonoBehaviour
{
    public Controls Controls;
    public Ship_Movement ship;

    void Awake(){
      Controls = new Controls();

      BindInputs();
    }

    public void BindInputs() {
        Controls.ZeroGShip.RotateXYaxis.performed += ctx => ship.rotationInputXY = ctx.ReadValue<Vector2>();
        Controls.ZeroGShip.MoveXYaxis.performed += ctx => ship.moveInputXY = ctx.ReadValue<Vector2>();
        Controls.ZeroGShip.MoveZaxis.performed += ctx => ship.moveInputZ = ctx.ReadValue<float>();
        Controls.ZeroGShip.RotateZaxis.performed += ctx => ship.rotationInputZ = ctx.ReadValue<float>();
    }

    // --- Enable/Disable --------------------------------

    // This will enable the Input Action Map
    private void OnEnable() {
        Controls.Enable();
    }

    // This will enable the Input Action Map
    private void OnDisable() {
        Controls.Disable();
    }
}
