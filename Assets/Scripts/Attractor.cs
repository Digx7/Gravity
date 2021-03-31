using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{

  const float G = 667.4f;

  public Vector3 initialForce;

  public static List<Attractor> Attractors;

  public Rigidbody rb;

  void FixedUpdate(){


    foreach(Attractor attractor in Attractors){
      if (attractor != this)
        Attract(attractor);
    }
  }

  void OnEnable(){
    if (Attractors == null)
      Attractors = new List<Attractor>();

    Attractors.Add(this);

    AddInitialForce();
  }

  void OnDisable(){
    Attractors.Remove(this);
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

  void AddInitialForce(){
    rb.AddRelativeForce(initialForce);
  }
}
