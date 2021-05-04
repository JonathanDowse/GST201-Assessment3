using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{

    
    public new AudioClip room1, room2, room3, room4, room5, transition, outside;

    new Color32 purple = new Color32(76, 7, 115, 200);
    new Color32 reddy = new Color32(255, 0, 0, 200);
    new Color32 bluey = new Color32(0, 97, 255, 200);
    new Color32 blacky = new Color32(0, 0, 0, 200);
    new Color32 greeny = new Color32(0, 255, 0, 200);
    

    public Image colorFader;

    // Start is called before the first frame update
    void Start()
    {
        colorFader.canvasRenderer.SetAlpha(0.0f);

        AudioSource musicChange = GetComponent<AudioSource>();
        musicChange.clip = outside;
        musicChange.volume = 1;
        musicChange.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Room1")
        {
            this.GetComponent<Image>().color = purple;
            colorFader.CrossFadeAlpha(0.15f, 1, false);

            AudioSource musicChange = GetComponent<AudioSource>();
            musicChange.clip = room1;
            musicChange.volume = 1;
            musicChange.Play();
        }

        if (collision.tag == "Room2")
        {
            this.GetComponent<Image>().color = reddy;
            colorFader.CrossFadeAlpha(0.15f, 1, false);
            AudioSource musicChange = GetComponent<AudioSource>();
            musicChange.clip = room2;
            musicChange.volume = 1;
            musicChange.Play();
        }

        if (collision.tag == "Room3")
        {
            this.GetComponent<Image>().color = bluey;
            colorFader.CrossFadeAlpha(0.15f, 1, false);
            AudioSource musicChange = GetComponent<AudioSource>();
            musicChange.clip = room3;
            musicChange.volume = 1;
            musicChange.Play();
        }

        if (collision.tag == "Room4")
        {
            this.GetComponent<Image>().color = blacky;
            colorFader.CrossFadeAlpha(0.5f, 1, false);
            AudioSource musicChange = GetComponent<AudioSource>();
            musicChange.clip = room4;
            musicChange.volume = 1;
            musicChange.Play();
        }

        if (collision.tag == "Room5")
        {
            this.GetComponent<Image>().color = greeny;
            colorFader.CrossFadeAlpha(0.15f, 1, false);
            
        }

        if (collision.tag == "Room5.1")
        {
            AudioSource musicChange = GetComponent<AudioSource>();
            musicChange.clip = room5;
            musicChange.volume = 1;
            musicChange.Play();
        }

        if (collision.tag == "Transition")
        {
            AudioSource musicChange = GetComponent<AudioSource>();
            musicChange.clip = transition;
            musicChange.volume = 1;
            musicChange.Play();

        }

        if (collision.tag == "Outdoors")
        {
            AudioSource musicChange = GetComponent<AudioSource>();
            musicChange.clip = outside;
            musicChange.volume = 1;
            musicChange.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Room1")
        {
            colorFader.CrossFadeAlpha(0, 1, false);
        }

        if (collision.tag == "Room2")
        {
            colorFader.CrossFadeAlpha(0, 1, false);
        }

        if (collision.tag == "Room3")
        {
            colorFader.CrossFadeAlpha(0, 1, false);
        }

        if (collision.tag == "Room4")
        {
            colorFader.CrossFadeAlpha(0, 1, false);
        }

        if (collision.tag == "Room5")
        {
            colorFader.CrossFadeAlpha(0, 1, false);
        }
    }
}
