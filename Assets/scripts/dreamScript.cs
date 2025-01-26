using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dreamScript : MonoBehaviour
{
    //This general script is used for 

    private bool timerIsRunning = true;
    [SerializeField] public bool gameFail = false;
    [SerializeField] public bool gameWin = false;
    [SerializeField] public float dreamTimer = 15.0f;
    

    private void Start()
    {
        timerIsRunning = true;
        //dreamTimer = 15.0f;
        //op = SceneManager.LoadSceneAsync(0);
        //op.allowSceneActivation = false;
        //Debug.Log("timer start");
        //StartCoroutine(UnloadAsyncScene());

        GameObject mngr = GameObject.Find("manager");
        gameManager.dreamNum = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Set LL to " + gameManager.dreamNum);

    }



    // Update is called once per frame
    private void Update()
    {

        if (timerIsRunning)
        {
            dreamTimer -= Time.deltaTime;
            
        }
        Debug.Log("dream timer: " + dreamTimer);
        if(dreamTimer < 0.0f || gameFail)
        {
            //End the dream as a failure!
            Debug.Log("Dream failed!");
            gameManager.strikes += 1;
            SceneManager.LoadScene(0);
        }
        else if (gameWin)
        {
            //End the dream as a success!
            //SceneManager.LoadScene(0);
            Debug.Log("Dream won!");
            SceneManager.LoadScene(0);
        }

    }

    

}
