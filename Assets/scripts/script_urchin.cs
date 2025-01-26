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
    }
}
