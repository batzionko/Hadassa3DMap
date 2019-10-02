using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destination : MonoBehaviour
{
    public new Transform rigidbody;
    public Transform target;
    public Text text;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        //&& Math.Abs((int)rigidbody.position.y -(int)target.position.y)<=4
        //&& Math.Abs((int)rigidbody.position.z - (int)target.position.z) <= 4
        
        if (Math.Abs(rigidbody.position.x- target.position.x)<=2f&& Math.Abs(rigidbody.position.y - target.position.y) <= 2f&& Math.Abs(rigidbody.position.z - target.position.z) <= 2f)
        {
            text.enabled = true;

        }
        else
            text.enabled = false;
    }
}
