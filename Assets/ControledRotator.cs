using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControledRotator : MonoBehaviour
{

    public Vector2 rotationInput;
    public float rotationSpeed;

    public Vector3 rotation;

    void Update(){
      Rotate();
    }

    public void Rotate(){
      this.transform.Rotate(rotation, rotationSpeed * Time.deltaTime);
    }

    public void takeInInputXY(Vector2 _rotationInput){
      rotationInput = _rotationInput;
      rotation.x = rotationInput.y;
      rotation.y = rotationInput.x;
    }

    public void takeInInputZ(float zInput){
      rotation.z = zInput;
    }
}
