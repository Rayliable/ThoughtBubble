using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_urchin : MonoBehaviour
{

    public GameObject armUp;
    public GameObject armDown;
    public GameObject armLeft;
    public GameObject armRight;

    public SpriteRenderer urchIdle;
    public SpriteRenderer urchLose;
    public SpriteRenderer urchWin;

    [SerializeField] dreamScript Dream;

    public int poppedBub = 0;
    int targetBub = 16;

    // Start is called before the first frame update
    void Start()
    {
        armUp.SetActive(false);
        armDown.SetActive(false);
        armLeft.SetActive(false);
        armRight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            armUp.SetActive(true);
            armDown.SetActive(false);
            armLeft.SetActive(false);
            armRight.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            armUp.SetActive(false);
            armDown.SetActive(false);
            armLeft.SetActive(true);
            armRight.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            armUp.SetActive(false);
            armDown.SetActive(true);
            armLeft.SetActive(false);
            armRight.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            armUp.SetActive(false);
            armDown.SetActive(false);
            armLeft.SetActive(false);
            armRight.SetActive(true);
        }



        if(poppedBub >= targetBub)
        {
            Dream.timerIsRunning = false;
            //WINNNEERRR
            urchWin.enabled = true;
            urchIdle.enabled = false;
            //Time.timeScale = 0;
            Dream.gameWin = true;
        }

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bubblePop")
        {
            Dream.timerIsRunning = false;
            urchLose.enabled = true;
            urchIdle.enabled = false;
            //LOSE
            print("testLOSER");

            //Time.timeScale = 0;
            Dream.gameFail = true;
        }


        urchin_bubbleSpawn spawner1 = GameObject.Find("spawnerUp").GetComponent<urchin_bubbleSpawn>();
        urchin_bubbleSpawn spawner2 = GameObject.Find("spawnerDown").GetComponent<urchin_bubbleSpawn>();
        urchin_bubbleSpawn spawner3 = GameObject.Find("spawnerRight").GetComponent<urchin_bubbleSpawn>();
        urchin_bubbleSpawn spawner4 = GameObject.Find("spawnerLeft").GetComponent<urchin_bubbleSpawn>();

    

    }
}
