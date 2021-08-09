using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PathPredictor : MonoBehaviour
{
    [SerializeField] private static Scene predictionScene, currentScene;
    [SerializeField] private static PhysicsScene predictionPhysicsScene, currentPhysicsScene;

    [SerializeField] private GameObject virtualAttractorPrefab;

    [SerializeField] private int numberOfIterations;

    [SerializeField] private Vector3 referencePosition;

    public void Awake(){
      SetUp();
    }

    public void Start(){
      RunSimulation(true);
    }

    public void FixedUpdate(){
      if (currentPhysicsScene.IsValid()){
          currentPhysicsScene.Simulate(Time.fixedDeltaTime);
      }
    }

    private void SetUp(){

      currentScene = SceneManager.GetActiveScene();
      currentPhysicsScene = currentScene.GetPhysicsScene();

      CreateSceneParameters parameters = new CreateSceneParameters(LocalPhysicsMode.Physics3D);
      predictionScene = SceneManager.CreateScene("Prediction", parameters);
      predictionPhysicsScene = predictionScene.GetPhysicsScene();

      Physics.autoSimulation = false;
    }

    private void CreateVirtualAttractors(){
      foreach(Attractor attractor in Attractor.Attractors){
        Vector3 spawnPoint = attractor.transform.position + (attractor.transform.rotation * new Vector3 (1.1f, 0, 1.1f));
        GameObject virtualObject = Instantiate(virtualAttractorPrefab, spawnPoint, Quaternion.identity);
        SceneManager.MoveGameObjectToScene(virtualObject, predictionScene);
        virtualObject.transform.position = attractor.gameObject.transform.position;
        virtualObject.transform.rotation = attractor.gameObject.transform.rotation;

        Attractor virtualAttractor = virtualObject.GetComponent<Attractor>();
        virtualAttractor.SetUp(attractor, true);

        if(virtualAttractor.drawLine)virtualObject.GetComponent<LineRenderer>().positionCount = numberOfIterations;
      }
    }

    private void SimulateVirtualAttractors(bool initialForceSetUp = false){
      foreach(Attractor va in Attractor.virtualAttractors){
        if(initialForceSetUp)va.AddInitialForce();
        else va.rb.velocity = va.velocity;
      }
      for (int i = 0; i < numberOfIterations; i++){
        predictionPhysicsScene.Simulate(Time.fixedDeltaTime);
        foreach(Attractor va in Attractor.virtualAttractors){
          va.SimulateGravity();
          if(va.drawLine)va.gameObject.GetComponent<LineRenderer>().SetPosition(i, va.gameObject.transform.position);
        }
      }
    }

    public void RunSimulation(bool initialForceSetUp = false){
      CreateVirtualAttractors();
      SimulateVirtualAttractors(initialForceSetUp);
    }

    public void ClearSimulation(){
      //Attractor.virtualAttractors.Clear();
      int steps = Attractor.virtualAttractors.Count;
      for(int i = 0; i < steps; i++){
        Attractor firstAttractor = Attractor.virtualAttractors[0];
        Attractor.virtualAttractors.Remove(firstAttractor);
        Destroy(firstAttractor.gameObject);
      }
      Debug.Log("Simulation has been cleared");
    }

    public void PrintVirtualAttractorCount(){
      Debug.Log("The Number of Virtual Attractors is : " + Attractor.virtualAttractors.Count);
    }
}
