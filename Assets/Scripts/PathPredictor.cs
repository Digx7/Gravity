using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PathPredictor : MonoBehaviour
{
    [SerializeField] private Scene predictionScene, currentScene;
    [SerializeField] private PhysicsScene predictionPhysicsScene, currentPhysicsScene;

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

        Attractor virtualAttractor = virtualObject.GetComponent<Attractor>();
        virtualAttractor.SetUp(attractor.rb.mass, attractor.initialForce, true);
      }
    }

    private void RunSimulation(){
      for (int i = 0; i < numberOfIterations; i++){
        predictionPhysicsScene.Simulate(Time.fixedDeltaTime);
      }
    }
}
