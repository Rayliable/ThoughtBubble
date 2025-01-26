using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{
    [SerializeField] dreamScript Dream;
    public Slider timerBar;
    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Slider>();
        timerBar.value = 15;
    }

    // Update is called once per frame
    void Update()
    {
        timerBar.value = Dream.dreamTimer;
    }
}
