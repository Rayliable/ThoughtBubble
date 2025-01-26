using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdClose : MonoBehaviour
{
    [SerializeField] SpawnAndCountAds AdSpawner;
    public Button X_Button;
    public GameObject Advert;
    // Start is called before the first frame update
    void Start()
    {
        X_Button = GetComponent<Button>();
        X_Button.onClick.AddListener(CloseAdWindow);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CloseAdWindow()
    {
        AdSpawner.adClosedCount++;
        Debug.Log("CLICKED");
        Destroy(Advert);
        Destroy(X_Button);
    }
}
