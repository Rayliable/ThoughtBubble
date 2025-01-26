using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{

    public Button retryButton;


    // Start is called before the first frame update
    void Start()
    {
        retryButton = GetComponent<Button>();
        retryButton.onClick.AddListener(retry);
    }

    // Update is called once per frame
    void retry()
    {
        Debug.Log("retrying game.");
        gameManager.InitGame();
        SceneManager.LoadScene(0);
    }
}
