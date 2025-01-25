using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class livesScript : MonoBehaviour
{
    public int lifeCount = 3;

    [SerializeField]
    private TMP_Text lifeText;

    // Start is called before the first frame update
    void Start()
    {
        lifeText.text = "Lives = " + lifeCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
