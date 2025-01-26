using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.tvOS;

public class script_hitman : MonoBehaviour
{
    int wantedRand;
    private GameObject targetTo;
    private GameObject wantedP;
    // Start is called before the first frame update
    public Texture2D gun;

    public SpriteRenderer remIdle;
    public SpriteRenderer remLose;
    public SpriteRenderer remWin;
    public SpriteRenderer bullet;
    void Start()
    {
        
        wantedRand = (Random.Range(1, 5));
        
        switch (wantedRand)
        {
            case 1:
                targetTo = GameObject.Find("targetp1");
                wantedP = GameObject.Find("wanted1");
               
                break;
            case 2:
                targetTo = GameObject.Find("targetp2");
                wantedP = GameObject.Find("wanted2");
             
                break;
            case 3:
                targetTo = GameObject.Find("targetp3");
                wantedP = GameObject.Find("wanted3");
              
                break;
            case 4:
                targetTo = GameObject.Find("targetp4");
                wantedP = GameObject.Find("wanted4");
              
                break;
            case 5:
                targetTo = GameObject.Find("targetp5");
                wantedP = GameObject.Find("wanted5");
           
                break;
        }
        GameObject.Find("targetp1").SetActive(false);
        GameObject.Find("targetp2").SetActive(false);
        GameObject.Find("targetp3").SetActive(false);
        GameObject.Find("targetp4").SetActive(false);
        GameObject.Find("targetp5").SetActive(false);

        GameObject.Find("wanted1").SetActive(false);
        GameObject.Find("wanted2").SetActive(false);
        GameObject.Find("wanted3").SetActive(false);
        GameObject.Find("wanted4").SetActive(false);
        GameObject.Find("wanted5").SetActive(false);

        if (targetTo != null)
        {
            targetTo.SetActive(true);
            wantedP.SetActive(true);
          
        }
        print(wantedRand);
        Vector2 cursorOffset = new Vector2(gun.width / 2, gun.height / 2);
        Cursor.SetCursor(gun, cursorOffset, CursorMode.ForceSoftware);
    }

    private void OnMouseDown()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if(hit.collider != null && hit.collider.gameObject.tag == "targetShoot") {
                remWin.enabled = true;
                remIdle.enabled = false;

                Destroy(targetTo);
                bullet.enabled = false;

                // WIN  SCREEN
                //TIMER FOR 3 SECONDS UNTIL BACK TO TRANSITION
            }
            else
            {
                //LOSE!!!
                remLose.enabled = true;
                remIdle.enabled = false;

                bullet.enabled = false;

                // LOSE SCREEN
                //TIMER FOR 3 SECONDS UNTIL BACK TO TRANSITION


            }

        }
    }
}
