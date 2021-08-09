using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInNOut : MonoBehaviour
{
    public float moveSpeed;
    public float ZoomInput;

    Vector3 movement;

    public void Update(){
      this.transform.Translate(movement);
    }

    public void takeInInput(float input){
      ZoomInput = input;

      movement.z = ZoomInput * moveSpeed * Time.deltaTime;
    }
}
