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
    public Image home;
    public Image intsruction;
    // Start is called before the first frame update

    [SerializeField] private string newGameLv = "mainScene";
    public void NewButton()
    {
       SceneManager.LoadScene(newGameLv);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
