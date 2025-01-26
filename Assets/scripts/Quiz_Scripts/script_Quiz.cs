using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_Quiz : MonoBehaviour
{
    public bool Q1Selected = false;
    public bool Q2Selected = false;
    public bool Q1Correct = false;
    public bool Q2Correct = false;
    public bool win = false;
    public bool lose = false;
    public static script_Quiz Instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Q1Correct && Q2Correct)
        {
            win= true;
            GameObject.Find("manager").GetComponent<dreamScript>().gameWin = true;

        }
        else if (Q1Selected && Q2Selected && (Q1Correct == false || Q2Correct == false)) 
        {
            lose= true;

            GameObject.Find("manager").GetComponent<dreamScript>().gameFail = true;
        }

    }
}
