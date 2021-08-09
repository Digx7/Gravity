using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Map_ControlsHandler : MonoBehaviour
{
  public Controls Controls;

  public Vector2Event RotateXYInputEvent;
  public FloatEvent RotateZInputEvent;
  public FloatEvent CycleReferencePointInputEvent;
  public FloatEvent ZoomInNOutInputEvent;
  public UnityEvent ClearSimulationInputEvent;
  public UnityEvent NewSimulationInputEvent;

  void Awake(){
    Controls = new Controls();

    BindInputs();
  }

  public void BindInputs() {
    Controls.Map.RotateXYaxis.performed += ctx => RotateXYInputEvent.Invoke(ctx.ReadValue<Vector2>());
    Controls.Map.RotateZaxis.performed += ctx => RotateZInputEvent.Invoke(ctx.ReadValue<float>());
    Controls.Map.CycleReferencePoint.performed += ctx => CycleReferencePointInputEvent.Invoke(ctx.ReadValue<float>());
    Controls.Map.ZoomInNOut.performed += ctx => ZoomInNOutInputEvent.Invoke(ctx.ReadValue<float>());
    Controls.Map.ClearSimulation.performed += ctx => ClearSimulationInputEvent.Invoke();
    Controls.Map.NewSimulation.performed += ctx => NewSimulationInputEvent.Invoke();
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
