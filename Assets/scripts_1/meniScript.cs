using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;
using JetBrains.Annotations;

public class meniScript : MonoBehaviour
{
    public Button button;
    public Image home;
    public Image intsruction;
    public Image playButtonImg;
    // Start is called before the first frame update

    
    public void playButton()
    {
       SceneManager.LoadSceneAsync(1);
    }
    public void introButton()
    {
        intsruction.enabled = !intsruction.enabled;
        playButtonImg.enabled = !playButtonImg.enabled;
    }
   

    // Update is called once per frame
    
}
