using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingScript : MonoBehaviour
{
    //Order:

    //Check lives
    //Pick scene at random (verify not same as previous scene)
    //Begin async loading. Start load timer
    //While loading, display name / instructions
    //Once loaded && min amt of load time has passed, 
    //Transition


    // Start is called before the first frame update
    void Start()
    {
        //Get strike count from manager script
        GameObject mngr = GameObject.Find("manager");
        int currStrikes = mngr.GetComponent<strikeScript>().strikeCount;

        //Check lives
        if(currStrikes >= 3)
        {
            Debug.Log("3 Strikes! You're out.");
            //TODO - game over here
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
