using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Animator anim;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if(moveInput == 0){
            anim.SetBool("Running", false);
        }
        else{
            anim.SetBool("Running", true);
        }

        if(moveInput < 0){
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if(moveInput > 0){
            transform.eulerAngles = new Vector2(0, 0);
        }
        


    }
}
