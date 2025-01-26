using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnAndCountAds : MonoBehaviour
{
    public GameObject adVariation1;
    public GameObject adVariation2;
    public GameObject adVariation3;
    public GameObject adVariation4;
    public GameObject adVariation5;
    public GameObject adVariation6;
    public GameObject adVariation7;
    public GameObject adVariation8;
    public int adSpawnCount = 0;
    static private int adClosedCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAds());
    }

    IEnumerator SpawnAds()
    {
        int adVariation = 0;
        adClosedCount = 0;
        Vector3 SpawnPos = Vector3.zero;
        adSpawnCount = Random.Range(8, 12);
        Debug.Log("waiting");
        for (int i = 0; i < adSpawnCount; i++)
        {
            adVariation = Random.Range(0, 7);
            switch (adVariation)
            {
                case 0:
                    SpawnPos = new Vector3(Random.Range(-8, 6), Random.Range(-4, 3), 0f);
                    adVariation1 = Instantiate(adVariation1, SpawnPos, Quaternion.identity);
                    break;
                case 1:
                    SpawnPos = new Vector3(Random.Range(-8, 6), Random.Range(-4, 3), 0f);
                    adVariation2 = Instantiate(adVariation2, SpawnPos, Quaternion.identity);
                    break;
                case 2:
                    SpawnPos = new Vector3(Random.Range(-8, 6), Random.Range(-4, 3), 0f);
                    adVariation3 = Instantiate(adVariation3, SpawnPos, Quaternion.identity);
                    break;
                case 3:
                    SpawnPos = new Vector3(Random.Range(-8, 6), Random.Range(-4, 3), 0f);
                    adVariation4 = Instantiate(adVariation4, SpawnPos, Quaternion.identity);
                    break;
                case 4:
                    SpawnPos = new Vector3(Random.Range(-8, 6), Random.Range(-4, 3), 0f);
                    adVariation5 = Instantiate(adVariation5, SpawnPos, Quaternion.identity);
                    break;
                case 5:
                    SpawnPos = new Vector3(Random.Range(-8, 6), Random.Range(-4, 3), 0f);
                    adVariation6 = Instantiate(adVariation6, SpawnPos, Quaternion.identity);
                    break;
                case 6:
                    SpawnPos = new Vector3(Random.Range(-8, 6), Random.Range(-4, 3), 0f);
                    adVariation7 = Instantiate(adVariation7, SpawnPos, Quaternion.identity);
                    break;
                case 7:
                    SpawnPos = new Vector3(Random.Range(-8, 6), Random.Range(-4, 3), 0f);
                    adVariation8 = Instantiate(adVariation8, SpawnPos, Quaternion.identity);
                    break;
            }
            yield return new WaitForSeconds(0.1f);
        }
        Debug.Log("waited");
    }
    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(adClosedCount);
        if (adClosedCount >= adSpawnCount)
        {
            endMinigame();
        }
    }
    public void adClosedAdd()
    {
        adClosedCount++;
        Debug.Log(adClosedCount);
    }
    void endMinigame()
    {
        Debug.Log("GAME ENDED!");
    }
}
