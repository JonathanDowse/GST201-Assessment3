using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeFrameSprite : MonoBehaviour
{
    public Sprite sprite1, sprite2, sprite3;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpriteChange1", 0.4f);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpriteChange1()
    {
        this.GetComponent<SpriteRenderer>().sprite = sprite1;
        Invoke("SpriteChange2", 0.4f);
    }
    void SpriteChange2()
    {
        this.GetComponent<SpriteRenderer>().sprite = sprite2;
        Invoke("SpriteChange3", 0.4f);

    }
    void SpriteChange3()
    {
        this.GetComponent<SpriteRenderer>().sprite = sprite3;
        Invoke("SpriteChange1", 0.4f);

    }
}