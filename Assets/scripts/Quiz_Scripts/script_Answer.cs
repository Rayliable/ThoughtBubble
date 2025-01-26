using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_Answer : MonoBehaviour
{
    public SpriteRenderer Answer;
    public bool correct;
    public bool selected = false;
    //public bool Q1Selected;
    // Start is called before the first frame update
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
        if (script_Quiz.Instance.Q1Selected == false)
        {
            Answer.enabled = true;
            selected = true;
            script_Quiz.Instance.Q1Selected = true;
            if (correct)
            {
                script_Quiz.Instance.Q1Correct = true;
            }
        }
    }
}

