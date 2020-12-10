using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountObjects : MonoBehaviour {
    
    public GameObject objToDestroy;
    GameObject objUI;
	
	void Start()
    {
        objUI = GameObject.Find("ObjectNum");
    }
	
	void Update() {
        objUI.GetComponent<Text>().text = "Items to Collect: " + ObjectsToCollect.objects.ToString();
        
        if (ObjectsToCollect.objects == 0)
        {
            Destroy(objToDestroy);
            objUI.GetComponent<Text>().text = "All items collected.";
        }

	}
}
