using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urchin_bubbleSpawn : MonoBehaviour
{
    public GameObject bubblePrefab;
    public Transform spawner;
    int maxBubble = 10;

    private int numBubble = 0;

    public bool allpopped = false;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBubbles());
    }
    private IEnumerator SpawnBubbles()
    {
       
        while(numBubble < maxBubble) {
            float waitTime = Random.Range(1f, 3f);
            yield return new WaitForSeconds(waitTime);
            GameObject bubble = Instantiate(bubblePrefab, spawner.position, Quaternion.identity);

          //  Vector2 direction = spawner.right; // Assumes spawner's right is the direction
           // bubble.GetComponent<BubbleMovement>().direction = direction;

            numBubble++;


        }
        
    }


    // Update is called once per frame
    
    void Update()
    {
       
    }
}
