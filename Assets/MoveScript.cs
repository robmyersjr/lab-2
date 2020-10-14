using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
   private  Rigidbody rb;
   public float speed;

   // Start is caleled before the first frame update 
   private void Start() 
{
rb = GetComponent<Rigidbody>();
}

private void FixedUpdate()
{

float h = Input.GetAxis("Horizontal");
float v = Input.GetAxis("Vertical");

Vector3 movement = new Vector3(h, 0.0f, v);
rb.AddForce(movement * speed);
}

}