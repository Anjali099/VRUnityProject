using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    
    public Transform theDest;
    public Rigidbody rb;

    public void Start()
    {

        rb = GetComponent<Rigidbody>();

    }


    private void OnMouseDown()
    {
        GetComponent<Collider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        //rb.GetComponent<Rigidbody>().isKinematic = true;
        //rb.isKinematic = true;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("hand").transform;
        
    }


    // when not pressing the mouse key down
    private void OnMouseUp()
    {
        this.transform.parent = null;
        //rb.GetComponent<Rigidbody>().isKinematic = false;
        //rb.isKinematic = false;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().freezeRotation = false;
        GetComponent<Collider>().enabled = true;
      

    }
}
