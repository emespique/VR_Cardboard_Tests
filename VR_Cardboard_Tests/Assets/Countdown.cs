using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
	public GameObject textDisplay;
	public int secondsLeft=60;
    public int minutesLeft=15;
	public bool reducedTime=false;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "15:00";
    }

    // Update is called once per frame
    void Update()
    {
        if(reducedTime==false && secondsLeft>0 && minutesLeft>0)
        {
        	StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake(){
    	reducedTime=true; //may nababawas na time
    	yield return new WaitForSeconds(1);
    	secondsLeft-=1;
        if(secondsLeft==0){
            if(minutesLeft<10 && minutesLeft!=0){
                textDisplay.GetComponent<Text>().text = "0" + minutesLeft + ":0" + secondsLeft;
            }
            else if(minutesLeft>9){
                textDisplay.GetComponent<Text>().text = minutesLeft + ":0" + secondsLeft;
            }
            minutesLeft-=1;
            secondsLeft=60;
        }
        else{
            if(secondsLeft<10 && secondsLeft!=0 && minutesLeft<10 && minutesLeft!=0)//01:09
            {
                textDisplay.GetComponent<Text>().text = "0" + minutesLeft + ":0" + secondsLeft;
            }
            else if(secondsLeft<10 && secondsLeft!=0 && minutesLeft>9)//10:01
            {
    	       textDisplay.GetComponent<Text>().text = minutesLeft + ":0" + secondsLeft;
            } 
            else if(secondsLeft>9 && minutesLeft<10 && minutesLeft!=0)//09:05
            {
                textDisplay.GetComponent<Text>().text = "0" + minutesLeft + ":" + secondsLeft;
            } 
            else{//
                textDisplay.GetComponent<Text>().text = minutesLeft + ":" + secondsLeft;
            }
        }

    	reducedTime=false;
    }
}
