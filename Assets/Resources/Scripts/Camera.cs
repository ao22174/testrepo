using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
  // This is expressed in "units per second".
  public float speed = 1f;
 
  void Update() {
    if (Input.GetKey(KeyCode.A)) {
      Camera.main.transform.position += new Vector3(-5, 0 , 0) * Time.deltaTime * speed;
    }
    if (Input.GetKey(KeyCode.D)) {
      Camera.main.transform.position += new Vector3(5, 0, 0) * Time.deltaTime * speed;
    }
     if (Input.GetKey(KeyCode.W)) {
      Camera.main.transform.position += new Vector3(0, 5, 0) * Time.deltaTime * speed;
    }
    if (Input.GetKey(KeyCode.S)) {
      Camera.main.transform.position += new Vector3(0, -5, 0) * Time.deltaTime * speed;
    }
    
  } 
}

