using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform objectToFollow;
    public Transform CelestialObjectsParents;
    public int index;

    void Start(){
      objectToFollow = CelestialObjectsParents.GetChild(index);
    }

    public void Update(){
      this.transform.position = objectToFollow.position;
    }

    public void CycleObjectToFollow(float input){
      index += (int)input;
      if(index == CelestialObjectsParents.childCount) index = 0;
      if(index == -1) index = CelestialObjectsParents.childCount - 1;
      objectToFollow = CelestialObjectsParents.GetChild(index);
    }
}
