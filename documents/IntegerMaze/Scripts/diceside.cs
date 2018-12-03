using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceside : MonoBehaviour {

    bool onGround;
    public int sideValue;

    public void OnTriggerStay(Collider col)
    {
        if(col.tag == "Ground")
        {
            onGround = true;
        }
    }
    
	public void OnTriggerExit(Collider col)
    {
        if(col.tag == "Ground")
        {
            onGround = false;
        }
    }
    
    public bool OnGround()
    {
        return onGround;
    }
}
