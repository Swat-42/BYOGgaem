using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;


    void Update()
    {
        if(Input.GetKey("w")){
            rb.AddForce(0,0, 300f * Time.deltaTime);
          }
        if(Input.GetKey("s")){
            rb.AddForce(0,0, -300f * Time.deltaTime);
          }
        if(Input.GetKey("d")){
            rb.AddForce(300f * Time.deltaTime,0, 0);
          }
        if(Input.GetKey("a")){
            rb.AddForce(-300f * Time.deltaTime,0,0);
          }
    }
}
