using System.Collections;
using System.Collections.Generic;
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
    public int adSpawnCount;
    public int adClosedCount;
    // Start is called before the first frame update
    void Start()
    {
        int adVaration = 0;
        adClosedCount = 0;
        Vector3 SpawnPos = Vector3.zero;
        adSpawnCount = Random.Range(8, 12);
        for (int i = 0; i < adSpawnCount; i++)
        {
            adVaration = Random.Range(0, 7);
            switch (adVaration)
            {
                case 0:
                    SpawnPos = new Vector3(Random.Range(0, 12), Random.Range(0, 12), 0f);
                    adVariation1 = Instantiate(adVariation1, SpawnPos, Quaternion.identity);
                    break;
                case 1:
                    SpawnPos = new Vector3(Random.Range(0, 12), Random.Range(0, 12), 0f);
                    adVariation2 = Instantiate(adVariation1, SpawnPos, Quaternion.identity);
                    break;
                case 2:
                    SpawnPos = new Vector3(Random.Range(0, 12), Random.Range(0, 12), 0f);
                    adVariation3 = Instantiate(adVariation1, SpawnPos, Quaternion.identity);
                    break;
                case 3:
                    SpawnPos = new Vector3(Random.Range(0, 12), Random.Range(0, 12), 0f);
                    adVariation4 = Instantiate(adVariation1, SpawnPos, Quaternion.identity);
                    break;
                case 4:
                    SpawnPos = new Vector3(Random.Range(0, 12), Random.Range(0, 12), 0f);
                    adVariation5 = Instantiate(adVariation1, SpawnPos, Quaternion.identity);
                    break;
                case 5:
                    SpawnPos = new Vector3(Random.Range(0, 12), Random.Range(0, 12), 0f);
                    adVariation6 = Instantiate(adVariation1, SpawnPos, Quaternion.identity);
                    break;
                case 6:
                    SpawnPos = new Vector3(Random.Range(0, 12), Random.Range(0, 12), 0f);
                    adVariation7 = Instantiate(adVariation1, SpawnPos, Quaternion.identity);
                    break;
                case 7:
                    SpawnPos = new Vector3(Random.Range(0, 12), Random.Range(0, 12), 0f);
                    adVariation8 = Instantiate(adVariation1, SpawnPos, Quaternion.identity);
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (adClosedCount >= adSpawnCount)
        {
            endMinigame();
        }
        else
        {
            Debug.Log("AD CLOSED!");
        }
    }

    void endMinigame()
    {
        Debug.Log("GAME ENDED!");
    }
}
