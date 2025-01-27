using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_Grade : MonoBehaviour
{
    public Sprite AGrade;
    public Sprite FGrade;
    public SpriteRenderer Grade;

    [SerializeField] dreamScript Dream;

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
            StartCoroutine(endMinigame());
        }
        else if (script_Quiz.Instance.lose == true)
        {
            Grade.enabled = true;
            Grade.sprite = FGrade;
            StartCoroutine(failMinigame());
        }
    }
    IEnumerator endMinigame()
    {
        Dream.timerIsRunning = false;
        yield return new WaitForSeconds(2);
        Dream.gameWin = true;
        Debug.Log("GAME ENDED!");
    }
    IEnumerator failMinigame()
    {
        Dream.timerIsRunning = false;
        yield return new WaitForSeconds(2);
        Dream.gameFail = true;
        Debug.Log("GAME ENDED!");
    }
}
