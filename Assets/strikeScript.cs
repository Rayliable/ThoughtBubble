using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class livesScript : MonoBehaviour
{
    public int strikeCount = 0;

    [SerializeField]
    private TMP_Text strikeText;

    // Start is called before the first frame update
    void Start()
    {
        strikeText.text = "Strikes = " + strikeCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addStrike()
    {
        strikeCount++;
        Debug.Log("Added strike. Count: " +strikeCount);
    }
}
