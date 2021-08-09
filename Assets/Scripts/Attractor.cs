using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{

  public static List<Attractor> Attractors;
  public static List<Attractor> virtualAttractors;

  public static float G = Universe_Settings.gravitationalConstant;
  public Rigidbody rb;
  public Vector3 initialForce;
  public Vector3 velocity;
  public bool drawLine = false;
  public bool isReferencePosition = false;

  public bool isVirtualAttractor = false;

  public void SetUp(Attractor otherAttractor, bool _isVirtualAttractor = false){
    rb = gameObject.GetComponent<Rigidbody>();
    rb.mass = otherAttractor.rb.mass;
    initialForce = otherAttractor.initialForce;
    velocity = otherAttractor.rb.velocity;
    drawLine = otherAttractor.drawLine;
    isVirtualAttractor = _isVirtualAttractor;
  }

  void FixedUpdate(){
    SimulateGravity();
  }

  public void SimulateGravity(){
    if(!isVirtualAttractor){
      foreach(Attractor attractor in Attractors){
        if (attractor != this)
          Attract(attractor);
      }
    }
    else{
      foreach(Attractor virtualAttractor in virtualAttractors){
        if (virtualAttractor != this)
          Attract(virtualAttractor);
      }
    }
  }

  void OnEnable(){
    if(!isVirtualAttractor){
      if (Attractors == null)
        Attractors = new List<Attractor>();

      Attractors.Add(this);
    }
    else{
      if (virtualAttractors == null)
        virtualAttractors = new List<Attractor>();

      virtualAttractors.Add(this);
    }

    AddInitialForce();
  }

  void OnDisable(){
    if(!isVirtualAttractor)Attractors.Remove(this);
    else virtualAttractors.Remove(this);
  }

  void Attract(Attractor objToAttract){
      Rigidbody rbToAttract = objToAttract.rb;

      Vector3 direction = rb.position - rbToAttract.position;

      //float distance = direction.magnitude;

      //float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);

      float distance = direction.sqrMagnitude;

      float forceMagnitude = G * (rb.mass * rbToAttract.mass) / distance;

      Vector3 force = direction.normalized * forceMagnitude;

      rbToAttract.AddForce(force);
  }

  public void AddInitialForce(){
    rb.AddRelativeForce(initialForce);
  }
}
