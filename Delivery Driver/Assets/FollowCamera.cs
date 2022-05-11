using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  [SerializeField] GameObject thingTofollow;
// this thing position (camera) should be the same as the car's position
    
    //I used LateUpdate insted just Update to smooth camera following process. 
    // update=beggining of the code, lateUpdate end of the code. +-
    void LateUpdate()
    {
      transform.position = thingTofollow.transform.position + new Vector3 (0,0,-10);
    }
}
