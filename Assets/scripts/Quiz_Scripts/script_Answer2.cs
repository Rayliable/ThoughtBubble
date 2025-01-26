using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_Answer2 : MonoBehaviour
{
    public SpriteRenderer Answer;
    public bool correct;
    public bool selected = false;
    void Start()
    {
        //Answer = GetComponent<GameObject>();
        Answer = GetComponent<SpriteRenderer>();
        Answer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (script_Quiz.Instance.Q2Selected == false)
        {
            Answer.enabled = true;
            selected = true;
            script_Quiz.Instance.Q2Selected = true;
            if (correct)
            {
                script_Quiz.Instance.Q2Correct = true;
            }
        }
    }
    
}
