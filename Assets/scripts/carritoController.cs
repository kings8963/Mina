using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carritoController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float speed = 1;
    [SerializeField] float move = 1;
    //  private bool canJump = false;
    //private bool isGrounded = true;
   // [SerializeField] float jumpForce = 1;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveCar();
      

    }

    public void moveCar()
    {
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        
    }


   
}
