using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioSource Menu;
    [SerializeField] AudioSource Test;
    [SerializeField] AudioSource Water;
    [SerializeField] AudioSource Tech;
    [SerializeField] AudioSource Spy;
    [SerializeField] AudioSource Eppy;
    [SerializeField] AudioSource Transition;
    [SerializeField] AudioSource Loss;

    public enum Music {None, Menu, Test, Water, Tech, Spy, Eppy, Transition, Loss};
    private Music playing = Music.None;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); ;
    }

    // Update is called once per frame
    public void PlayAudio(Music Type)
    {
        switch (Type)
        {
            case Music.Menu:
                if (playing != Music.Menu)
                {
                    Menu.Play();
                    playing = Music.Menu;
                }
                break;

            case Music.Test:
                if (playing != Music.Test)
                {
                    Test.Play();
                    playing = Music.Test;
                }
                break;

            case Music.Water:
                if (playing != Music.Water)
                {
                Water.Play();
                playing = Music.Water;
                }
                break;

            case Music.Tech:
                if (playing != Music.Tech)
                {
                    Tech.Play();
                    playing = Music.Tech;
                }
                break;

            case Music.Spy:
                if (playing != Music.Spy)
                {
                    Spy.Play();
                    playing = Music.Spy;
                }
                break;

            case Music.Eppy:
                if (playing != Music.Eppy)
                {
                    Eppy.Play();
                    playing = Music.Eppy;
                }
                break;

            case Music.Transition:
                if (playing != Music.Transition)
                {
                    Transition.Play();
                    playing = Music.Transition;
                }
                break;
            case Music.Loss:
                if (playing != Music.Loss)
                {
                    Loss.Play();
                    playing = Music.Loss;
                }
                break;

            default:
                playing = Music.None;
                break;
        }
    }
}
