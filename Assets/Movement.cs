using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 3;
    public Rigidbody2D Rigidbody1;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody1 = GetComponent < Rigidbody2D >();

    }

    // Update is called once per frame
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
        
        Rigidbody1.velocity = new Vector2(mov * speed, Rigidbody1.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody1.velocity = new Vector2(Rigidbody1.velocity.y, speed);
        }
        
    }
}
