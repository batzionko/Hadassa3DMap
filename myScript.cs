using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class myScript : MonoBehaviour
{
    public FixedJoystick moveJoystic;
    public FixedTouchField tuchField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.runAxis = moveJoystic.Direction;
        //
        fps.mouseLook.lookAxis=tuchField.TouchDist;
    }
}
