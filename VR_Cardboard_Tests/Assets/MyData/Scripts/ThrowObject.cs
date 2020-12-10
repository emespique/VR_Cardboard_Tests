using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    private Transform onHands;
    public float throwForce = 5000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Right Click to Throw");
        onHands = gameObject.transform.GetChild(0);
        
        if (Input.GetMouseButtonDown(1))
        {  
            onHands.GetComponent<Rigidbody>().isKinematic = false;
            onHands.transform.parent = null;
            onHands.GetComponent<Collider>().isTrigger = false;
            onHands.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * throwForce);
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<ThrowObject>().enabled = false;
        }
    }
}
