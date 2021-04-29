using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger2 : MonoBehaviour
{
    bool PlayerMoving;
    int SpriteInt;
    public Sprite idle1, idle2, walking1, walking2, walking3, walking4;
    // Start is called before the first frame update
    void Start()
    {

        SpriteInt = 1;
        InvokeRepeating("SpriteChange", 0, 1);
        
        // calling a function after a sort delay
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
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
            if (PlayerMoving == false)
            {
                if (SpriteInt == 1)
                {
                    this.GetComponent<SpriteRenderer>().sprite = idle1;
                }

                else if (SpriteInt == 2)
                {
                    this.GetComponent<SpriteRenderer>().sprite = idle2;
                    SpriteInt = 0;
                }
            }

            else if (PlayerMoving == true)
            {
                if (SpriteInt == 1)
                {
                    this.GetComponent<SpriteRenderer>().sprite = walking1;
                }

                else if (SpriteInt == 2)
                {
                    this.GetComponent<SpriteRenderer>().sprite = walking2;
                }

                else if (SpriteInt == 3)
                {
                    this.GetComponent<SpriteRenderer>().sprite = walking3;
                }

                else if (SpriteInt == 4)
                {
                    this.GetComponent<SpriteRenderer>().sprite = walking4;
                    SpriteInt = 0;
                }
            }
        SpriteInt++;
    }

    public void IdleCheck()
    {
        
    }
}    
