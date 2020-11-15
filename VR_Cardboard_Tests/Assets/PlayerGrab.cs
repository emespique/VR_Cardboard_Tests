using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
   	public GameObject Sphere;
	public GameObject myHands;
	
	bool inHands = false;
	Vector3 SpherePos;
	
    // Start is called before the first frame update
    void Start()
    {
        SpherePos = Sphere.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
		{
			if(!inHands) {
				Sphere.transform.SetParent(myHands.transform);
				Sphere.transform.localPosition = new Vector3(0f,-0.5f,0f);
				inHands = true;
			} else if (inHands)
			{
				this.GetComponent<PlayerGrab>().enabled = false;
				Sphere.transform.SetParent(null);
				Sphere.transform.localPosition = SpherePos;
				inHands = false;
			}
		}
    }
}
