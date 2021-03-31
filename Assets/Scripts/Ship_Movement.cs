using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector2 rotationInputXY, moveInputXY;
    public float moveInputZ, rotationInputZ;

    public float moveThrusterSpeed, rotationThrusterSpeed;

    void FixedUpdate(){
      shipRotation(rotationInputXY, rotationInputZ);
      shipMovement(moveInputXY, moveInputZ);
    }

    void shipRotation(Vector2 _rotationInputXY, float _rotationInputZ){
      Vector3 rotationDirection = new Vector3(_rotationInputZ, _rotationInputXY.x, _rotationInputXY.y);
      rb.AddRelativeTorque(rotationDirection * rotationThrusterSpeed);
    }

    void shipMovement(Vector2 _moveInputXY, float _moveInputZ){
      Vector3 moveDirection = new Vector3(_moveInputXY.y, _moveInputZ, -_moveInputXY.x);
      rb.AddRelativeForce(moveDirection * moveThrusterSpeed);
    }
}
