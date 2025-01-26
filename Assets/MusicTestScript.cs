using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTestScript : MonoBehaviour
{
    [SerializeField] private MusicManager musicManager;
    [SerializeField] private MusicManager.Music musicChoise;
    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.Find("GameMusic").GetComponent<MusicManager>();
        musicManager.PlayAudio(musicChoise);
    }
}
