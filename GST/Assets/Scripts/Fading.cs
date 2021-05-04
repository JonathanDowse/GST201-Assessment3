using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fading : MonoBehaviour
{

    public Image blackFade;
    // Start is called before the first frame update
    void Start()
    {
        blackFade.canvasRenderer.SetAlpha(0.0f);
        
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Transition")
        {
            fadeIn();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Transition")
        {
            fadeOut();
        }
    }



    void fadeIn()
    {
        blackFade.CrossFadeAlpha(1, 1, false);
    }

    void fadeOut()
    {
        blackFade.CrossFadeAlpha(0, 1, false);
    }
}
