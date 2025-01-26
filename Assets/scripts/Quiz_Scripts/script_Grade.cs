using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_Grade : MonoBehaviour
{
    public Sprite AGrade;
    public Sprite FGrade;
    public SpriteRenderer Grade;
    
    // Start is called before the first frame update
    void Start()
    {
        Grade = GetComponent<SpriteRenderer>();
        Grade.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (script_Quiz.Instance.win == true)
        {
            Grade.enabled = true;
            Grade.sprite = AGrade;
        }
        else if (script_Quiz.Instance.lose == true)
        {
            Grade.enabled = true;
            Grade.sprite = FGrade;
        }
    }
}
