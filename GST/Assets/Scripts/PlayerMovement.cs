using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Sprite walking1, walking2, walking3, walking4;
    Rigidbody2D rb;
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Indoors")
        {
            transform.position = new Vector3(transform.position.x, -3.72f, transform.position.z);
        }

        else if (collision.tag == "Outdoors")
        {
            transform.position = new Vector3(transform.position.x, -4.1f, transform.position.z);
        }
    }


    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        
        
    }
}
