using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadingScript : MonoBehaviour
{

    //Order:

    //  Store ref of prev scene
    //  Check lives
    //  Game over function
    //  Pick scene at random (verify not same as previous scene)
    //  Begin async loading. Start load timer
    //While loading, display name / instructions
    //  Once loaded && min amt of load time has passed, 
    //  Transition
    //TODO - add alternate scene transition for lose condition

    
    private bool isLoading = false;

    [SerializeField] private int dreamCount = 0;
    [SerializeField] private float loadTime = 3.0f;
    public int lastDream = 0;
    [SerializeField]  private Animator anim;
    [SerializeField] private Sprite[] _crossSprites;
    [SerializeField] private Image _crossImg;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.SetCursor(null, new Vector2(0,0), CursorMode.ForceSoftware);
        //anim = GameObject.Find("jump_00").GetComponent<Animator>();
        // unload last scene but store its id or name
        GameObject mngr = GameObject.Find("manager");
        
        lastDream = gameManager.dreamNum; //GM.lastLevel; //mngr.GetComponent<saveLevel>().levelNum;  //saveLevel.levelNum;

        //Get strike count from game manager script
        int currStrikes = gameManager.strikes;//mngr.GetComponent<strikeScript>().strikeCount;
        _crossImg.sprite = _crossSprites[currStrikes];

        Debug.Log("Your last dream was #" + lastDream );// " (" + SceneManager.GetSceneByBuildIndex(lastDream).name + "), you have " + currStrikes + " strikes.");

        //Check lives
        if (currStrikes >= 3)
        {
            Debug.Log("3 Strikes! You're out.");
            //TODO - game over here
            SceneManager.LoadScene("gameOver");
            return;
        }
        else
        {
            //pick scene to load
            //changed newDream to 1 so it will switch scenes in testing - Z
            int newDream = 1;

            //this caused an infinite loop when lastDream was anything other than 0!! This caused unity to look like it crashed. Commented it out as not to cause issues. - Z
            
            while (newDream == lastDream || newDream <=2 ) //Generate until it isn't the same as last dream
            {
                newDream = Random.Range(1, dreamCount +2); //double check docs for this one, doc
            }
            

            //begin async loading
            Debug.Log("Beginning async load for dream:" + newDream);
            StartCoroutine(LoadAsyncScene(newDream));

        }
    }

    private void Update()
    {
        if (isLoading)
        {
            loadTime -= Time.deltaTime;
            //Debug.Log("loading. timer: " + loadTime);
        }
    }

    IEnumerator LoadAsyncScene(int sceneIdx)
    {
        // Func modified from docs https://docs.unity3d.com/6000.0/Documentation/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        //loadTime = 10.0f;
        UnityEngine.AsyncOperation op = SceneManager.LoadSceneAsync(sceneIdx);
        op.allowSceneActivation = false;
        isLoading = true;

        // Wait until the asynchronous scene fully loads
        while (op.progress < 0.9f)// || loadTime > 0.0f)
        {
            //Debug.Log("Loading progress: " + (op.progress * 100) + "%");
            //loadTime -= Time.deltaTime;
            //TODO instructions / game name displayed here
            yield return null;
            
        }

        isLoading = false;
        Debug.Log("Dream Scene " + SceneManager.GetSceneByBuildIndex(sceneIdx).name + " has been loaded.");

        if(op.progress >= 0.9f){// && loadTime <= 0.0f) { //just to be safe lol
            //Scene switch TODO for transition
            Debug.Log("Switching to scene #" + sceneIdx);
            //animation here - jump
            anim.SetTrigger("OnUnderOne");

            yield return new WaitForSeconds(2);
            op.allowSceneActivation = true;
            //SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(sceneIdx));
        }

    }
}