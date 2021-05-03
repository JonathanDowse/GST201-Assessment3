using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public AudioClip grassStep1, grassStep2, woodStep1, woodStep2;
    bool PlayerMoving;
    int SpriteInt;
    public Sprite idle1, idle2, walking1, walking2, walking3, walking4;
    // Start is called before the first frame update
    void Start()
    {
        
        SpriteInt = 1;
        InvokeRepeating("SpriteChange", 0, 0.2f);

        // calling a function after a sort delay
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerMoving = true;
        }

        else
        {
            PlayerMoving = false;
        }
    }

    void SpriteChange()
    {


        if (PlayerMoving == true)
        {
            if (SpriteInt == 1)
            {
                this.GetComponent<SpriteRenderer>().sprite = walking1;
            }

            else if (SpriteInt == 2)
            {
                this.GetComponent<SpriteRenderer>().sprite = walking2;
                AudioSource stepping = GetComponent<AudioSource>();
                stepping.clip = woodStep1;
                stepping.Play();
            }

            else if (SpriteInt == 3)
            {
                this.GetComponent<SpriteRenderer>().sprite = walking3;
            }

            else if (SpriteInt == 4)
            {
                this.GetComponent<SpriteRenderer>().sprite = walking4;
                SpriteInt = 0;
                AudioSource stepping = GetComponent<AudioSource>();
                stepping.clip = woodStep2;
                stepping.Play();
            }
        }

        if (PlayerMoving == false)
        {
            if (SpriteInt == 1)
            {
                this.GetComponent<SpriteRenderer>().sprite = idle1;
            }

            else if (SpriteInt == 2)
            {
                this.GetComponent<SpriteRenderer>().sprite = idle1;

            }

            else if (SpriteInt == 3)
            {
                this.GetComponent<SpriteRenderer>().sprite = idle2;

            }

            else if (SpriteInt == 4)
            {
                this.GetComponent<SpriteRenderer>().sprite = idle2;
                SpriteInt = 0;
            }
        }

        SpriteInt++;
    }
}
