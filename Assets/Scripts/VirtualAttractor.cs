using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualAttractor
{
    public Vector3 position;
    public Vector3 velocity;
    public float mass;

    public VirtualAttractor (Attractor body){
      position = body.transform.position;
      velocity = body.initialForce;
      mass = body.rb.mass;
    }
}
