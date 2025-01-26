using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveLevel : MonoBehaviour
{

    [SerializeField] public int levelNum;
    // Start is called before the first frame update
    private void Start()
    {
        int currLevel = SceneManager.GetActiveScene().buildIndex;
        if (currLevel != 0)
        {
            levelNum = currLevel;
            Debug.Log("levelNum set to " + levelNum + ". ");
        }
        else
        {
            Debug.Log("We are in main.");
        }
    }
}

