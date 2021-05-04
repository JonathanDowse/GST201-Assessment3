using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backyard : MonoBehaviour
{
    public Text text1, text2;

    // Start is called before the first frame update
    void Start()
    {
        text1.canvasRenderer.SetAlpha(0.0f);
        text2.canvasRenderer.SetAlpha(0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            text1.CrossFadeAlpha(1, 2, false);
            Invoke("text2Fade", 3f);
        }
    }

    void text2Fade()
    {
        text2.CrossFadeAlpha(1, 2, false);
    }
}
