using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dreamScript : MonoBehaviour
{
    //This general script is used for 

    private bool timerIsRunning = true;
    [SerializeField] private bool gameFail = false;
    [SerializeField] private bool gameWin = false;
    [SerializeField] private float dreamTimer;
    

    private void Start()
    {
        timerIsRunning = true;
        dreamTimer = 10.0f;
        //op = SceneManager.LoadSceneAsync(0);
        //op.allowSceneActivation = false;
        //Debug.Log("timer start");
        //StartCoroutine(UnloadAsyncScene());

        GameObject mngr = GameObject.Find("manager");
        gameManager.Score = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Set LL to " + gameManager.Score);

    }

    IEnumerator UnloadAsyncScene()
    {
        // Func modified from docs https://docs.unity3d.com/6000.0/Documentation/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html
        
        UnityEngine.AsyncOperation op = SceneManager.UnloadSceneAsync(0);
        //op.allowSceneActivation = false;

        // Wait until the asynchronous scene fully loads
        while (op.progress < 0.9f)
        {
            //Debug.Log("Loading progress: " + (op.progress * 100) + "%");
            //loadTime -= Time.deltaTime;
            //TODO instructions / game name displayed here
            yield return null;

        }

        if (op.progress >= 0.9f)
        { //just to be safe lol
            Debug.Log("main unloaded.");
        }

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
            /*while (op.progress < 0.9f)
            {
                Debug.Log("Main scene still not loaded - please wait");
            }*/
            //op.allowSceneActivation = true;
            SceneManager.LoadScene(0);
        }
        else if (gameWin)
        {
            //End the dream as a success!
            //SceneManager.LoadScene(0);
            Debug.Log("Dream won!");
            /*while (op.progress < 0.9f)
            {
                Debug.Log("Main scene still not loaded - please wait");
            }*/
            //op.allowSceneActivation = true;
        }

    }

    

}
