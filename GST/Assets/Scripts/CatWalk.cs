using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatWalk : MonoBehaviour
{
    public Sprite catWalk1, catWalk2, catWalk3, catWalk4;
   
    // Start is called before the first frame update
    void Start()
    {
        
        Invoke("SpriteChange", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpriteChange()
    {
        this.GetComponent<SpriteRenderer>().sprite = catWalk1;
        Invoke("SpriteChange1", 0.2f);
    }
    void SpriteChange1()
    {
        this.GetComponent<SpriteRenderer>().sprite = catWalk2;
        Invoke("SpriteChange2", 0.2f);
    }

    void SpriteChange2()
    {
        this.GetComponent<SpriteRenderer>().sprite = catWalk3;
        Invoke("SpriteChange3", 0.2f);
    }

    void SpriteChange3()
    {
        this.GetComponent<SpriteRenderer>().sprite = catWalk4;
        Invoke("SpriteChange", 0.2f);
    }


}
