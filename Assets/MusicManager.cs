using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioSource Menu;
    [SerializeField] private AudioSource Test;
    [SerializeField] private AudioSource Water;
    [SerializeField] private AudioSource Tech;
    [SerializeField] private AudioSource Spy;
    [SerializeField] private AudioSource Eppy;
    [SerializeField] private AudioSource Transition;
    [SerializeField] private AudioSource Loss;

    //public AudioSource[] AudioSourses = { Menu, Test, Water, Tech, Spy, Eppy, Transition, Loss };
    public enum Music { Menu, Test, Water, Tech, Spy, Eppy, Transition, Loss, None};
    private Music playing = Music.None;
    
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    public void PlayAudio(Music Type)
    {
        /*if (playing != Type)
        {
            AudioSourses[Type].Stop();
        }*/
        if (playing != Type)
        {
            switch (playing)
            {
                case Music.Menu:
                    if (playing == Music.Menu)
                    {
                        Menu.Stop();
                        playing = Music.None;
                    }

                    break;

                case Music.Test:
                    if (playing == Music.Test)
                    {
                        Test.Stop();
                        playing = Music.None;
                    }
                    break;

                case Music.Water:
                    if (playing == Music.Water)
                    {
                        Water.Stop();
                        playing = Music.None;
                    }
                    break;

                case Music.Tech:
                    if (playing == Music.Tech)
                    {
                        Tech.Stop();
                        playing = Music.None;
                    }
                    break;

                case Music.Spy:
                    if (playing == Music.Spy)
                    {
                        Spy.Stop();
                        playing = Music.None;
                    }
                    break;

                case Music.Eppy:
                    if (playing == Music.Eppy)
                    {
                        Eppy.Stop();
                        playing = Music.None;
                    }
                    break;

                case Music.Transition:
                    if (playing == Music.Transition)
                    {
                        Transition.Stop();
                        playing = Music.None;
                    }
                    break;
                case Music.Loss:
                    if (playing == Music.Loss)
                    {
                        Loss.Stop();
                        playing = Music.None;
                    }
                    break;

                default:
                    playing = Music.None;
                    break;
            }
            
        }
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

