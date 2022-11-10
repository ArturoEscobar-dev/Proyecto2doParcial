using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        RotateAnimation();
    }
    private void RotateAnimation()
    {
        if (Input.GetAxis("Horizontal") > 0.01f) { 
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
         }
        else if (Input.GetAxis("Horizontal") < -0.01f)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        
    }
}
