using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite walking1, walking2, walking3, walking4, idle1, idle2;

    bool PlayerMoving = false;


    void Update()
    {


        IdleCheck();

        if (PlayerMoving == false)
        {
            IdleSprite0();
        }

        else
        {
            WalkingSprite0();
        }
        
    }
    
    public void IdleCheck()
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

    void IdleSprite0()
    {
        if (PlayerMoving == false)
        { 
        this.GetComponent<SpriteRenderer>().sprite = idle1;
        Invoke(nameof(IdleSprite1), 1f);
        }
    }

    void IdleSprite1()
    {
        if (PlayerMoving == false)
        {
            this.GetComponent<SpriteRenderer>().sprite = idle2;
            Invoke(nameof(IdleSprite0), 1f);
        }
    }

    void WalkingSprite0()
    {
        if (PlayerMoving == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = walking1;
            Invoke("WalkingSprite1", 1);
        }
    }

    void WalkingSprite1()
    {
        if (PlayerMoving == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = walking2;
            Invoke("WalkingSprite2", 1);
        }
    }

    void WalkingSprite2()
    {
        if (PlayerMoving == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = walking3;
            Invoke("WalkingSprite3", 1);
        }
    }

    void WalkingSprite3()
    {
        if (PlayerMoving == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = walking4;
            Invoke("WalkingSprite0", 1);
        }
    }
}
