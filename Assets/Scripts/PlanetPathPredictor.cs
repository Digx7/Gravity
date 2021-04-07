using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetPathPredictor : MonoBehaviour
{
    public int numSteps = 1000;
    public Attractor[] attractors;
    public VirtualAttractor[] virtualAttractors;
    public Vector3[][] drawPoints;
    public float timeStep = Universe_Settings.physicsTimeStep;

    public void Awake() {
      Time.fixedDeltaTime = Universe_Settings.physicsTimeStep;
    }

    public void Start() {
      attractors = FindObjectsOfType<Attractor>();
      virtualAttractors = new VirtualAttractor[attractors.Length];
      drawPoints = new Vector3[attractors.Length][];
      InitializeVirtualAttractors();
      RunSimulation();
    }

    public void RunSimulation() {
      SimulateVirtualAttractor();
      DrawVirtualPaths();
    }

    public void InitializeVirtualAttractors(){
      for (int i = 0; i < virtualAttractors.Length; i++){
        virtualAttractors[i] = new VirtualAttractor (attractors[i]);
        drawPoints[i] = new Vector3[numSteps];
      }
    }

    public void SimulateVirtualAttractor(){
      for (int step = 0; step < numSteps; step++){
        // Update Velocities
        for (int i = 0; i < virtualAttractors.Length; i++) {
          virtualAttractors[i].velocity += CalculateVirtualAcceleration(i) * timeStep;
        }
        // Update Positions
        for (int i = 0; i < virtualAttractors.Length; i++){
          Vector3 newPos = virtualAttractors[i].position + virtualAttractors[i].velocity * timeStep;
          virtualAttractors[i].position = newPos;

          drawPoints[i][step] = newPos;
        }
      }
    }

    public void DrawVirtualPaths(){
      for (int attractorIndex = 0; attractorIndex < virtualAttractors.Length; attractorIndex++) {
        var lineRenderer = attractors[attractorIndex].gameObject.GetComponentInChildren<LineRenderer> ();
        lineRenderer.positionCount = drawPoints[attractorIndex].Length;
        lineRenderer.SetPositions (drawPoints[attractorIndex]);
      }
    }

    private Vector3 CalculateVirtualAcceleration (int i) {
      Vector3 acceleration = Vector3.zero;
      for (int j = 0; j < virtualAttractors.Length; j++) {
          if (i == j) {
              continue;
          }
          //Vector3 forceDir = (virtualAttractors[j].position - virtualAttractors[i].position).normalized;
          //float sqrDst = (virtualAttractors[j].position - virtualAttractors[i].position).sqrMagnitude;
          //acceleration += forceDir * Universe_Settings.gravitationalConstant * virtualAttractors[j].mass / sqrDst;
          Vector3 direction = virtualAttractors[i].position - virtualAttractors[j].position;
          float distance = direction.sqrMagnitude;
          float forceMagnitude = Universe_Settings.gravitationalConstant * (virtualAttractors[i].mass * virtualAttractors[j].mass) / distance;
          Vector3 force = direction.normalized * forceMagnitude;
          acceleration += force;
      }
      return acceleration;
    }
}
