using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingScript : MonoBehaviour
{

    //Order:

    //Unload scene & store ref
    //  Check lives
    //  Pick scene at random (verify not same as previous scene)
    //  Begin async loading. Start load timer
    //While loading, display name / instructions
    //  Once loaded && min amt of load time has passed, 
    //Transition

    private float loadTime = 10.0f;

    [SerializeField]
    private int dreamCount;


    // Start is called before the first frame update
    void Start()
    {
        //TODO unload last scene but store its id or name
        int lastDream = 0; 

        //Get strike count from manager script
        GameObject mngr = GameObject.Find("manager");
        int currStrikes = mngr.GetComponent<strikeScript>().strikeCount;

        //Check lives
        if (currStrikes >= 3)
        {
            Debug.Log("3 Strikes! You're out.");
            //TODO - game over here
            return;
        }
        else
        {
            //pick scene to load
            int newDream = 0;
            while (newDream == lastDream) //Generate until it isn't the same as last dream
            {
                newDream = Random.Range(1, dreamCount + 1); //double check docs for this one, doc
            }

            //begin async loading & start load timer TODO
            Debug.Log("Beginning async load for dream:" + newDream);
            StartCoroutine(LoadAsyncScene(newDream));

        }
    }


    IEnumerator LoadAsyncScene(int sceneIdx)
    {
        // Func modified from docs https://docs.unity3d.com/6000.0/Documentation/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        loadTime = 10.0f;
        UnityEngine.AsyncOperation op = SceneManager.LoadSceneAsync(sceneIdx);
        op.allowSceneActivation = false;

        // Wait until the asynchronous scene fully loads
        while (op.progress < 0.9f)
        {
            Debug.Log("Loading progress: " + (op.progress * 100) + "%");
            loadTime -= Time.deltaTime;
            //TODO instructions / game name displayed here
            yield return null;
        }

        Debug.Log("Dream Scene #" + SceneManager.GetSceneByBuildIndex(sceneIdx).name + " has been loaded.");

        if(op.progress >= 0.9f && loadTime <= 0.0f) { 
            //Scene switch TODO for transition
            Debug.Log("Switching to scene #" + sceneIdx);
            op.allowSceneActivation = true;
            //SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        }

    }
}