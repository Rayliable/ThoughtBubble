using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playScript : MonoBehaviour
{
    public Button playButton;


    // Start is called before the first frame update
    void Start()
    {
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(play);
    }

    // Update is called once per frame
    void play()
    {
        Debug.Log("play game.");
        gameManager.InitGame();

        SceneManager.LoadScene("mainScene");
    }
}
