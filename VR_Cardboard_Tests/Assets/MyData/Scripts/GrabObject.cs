using UnityEngine;
using System.Collections;

public class GrabObject : MonoBehaviour
{
    public float distanceToGrab = 300f;
    private Transform player;
    private GameObject myHands;
    bool hasPlayer = false;


    void Start()
    {
        player = GameObject.Find("Player").transform;
        myHands = GameObject.Find("MyHands");

    }

    void Update()
    {
            float dist = Vector3.Distance(gameObject.transform.position, player.position);
           // Debug.Log("D: "+ dist +"Payer: " + player.position + "     object: " + gameObject.transform.position);
            if (dist <= distanceToGrab)
            {
                
                Debug.Log("Click to Grab");
                hasPlayer = true;

            }

            else
            {
                Debug.Log("can't reach");
                hasPlayer = false;
            }

            if (hasPlayer && Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = myHands.transform;
                GetComponent<Collider>().isTrigger = true;
                myHands.GetComponent<BoxCollider>().enabled = true;
                myHands.GetComponent<ThrowObject>().enabled = true;

        }

        
    }

}