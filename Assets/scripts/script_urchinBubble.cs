using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_urchinBubble : MonoBehaviour
{

    public Vector2 directionMove;
    private float speed = 0.8f;
    public script_urchin urchin;

    // Start is called before the first frame update
    void Start()
    {

        if (urchin == null) 
        {
            urchin = GameObject.Find("urchinIdle").GetComponent<script_urchin>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(directionMove * speed * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "urchinSpike")
        {

            print("trdsst");
            Destroy(gameObject);
            
            script_urchin urchinScript = urchin.GetComponent<script_urchin>();
            urchinScript.poppedBub++;
        }
      
        
    }
}