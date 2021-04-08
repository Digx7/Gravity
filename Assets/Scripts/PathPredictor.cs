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

    public void Awake(){
      SetUp();
    }

    public void Start(){
      CreateVirtualAttractors();
      RunSimulation();
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
        GameObject virtualObject = Instantiate(virtualAttractorPrefab);
        SceneManager.MoveGameObjectToScene(virtualObject, predictionScene);
        virtualObject.transform.position = attractor.gameObject.transform.position;
        virtualObject.transform.rotation = attractor.gameObject.transform.rotation;
        virtualObject.GetComponent<LineRenderer>().positionCount = numberOfIterations;

        Attractor virtualAttractor = virtualObject.GetComponent<Attractor>();
        virtualAttractor.SetUp(attractor.rb.mass, attractor.initialForce, true);
      }
    }

    private void RunSimulation(){
      foreach(Attractor va in Attractor.virtualAttractors) va.AddInitialForce();
      for (int i = 0; i < numberOfIterations; i++){
        predictionPhysicsScene.Simulate(Time.fixedDeltaTime);
        foreach(Attractor va in Attractor.virtualAttractors){
          va.SimulateGravity();
          va.gameObject.GetComponent<LineRenderer>().SetPosition(i, va.gameObject.transform.position);
        }
      }
    }

    private void ClearSimulation(){
      foreach(Attractor va in Attractor.virtualAttractors){
        Destroy(va.gameObject);
      }
    }
}
