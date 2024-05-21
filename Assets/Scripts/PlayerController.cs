using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    public float speed;
    public GameObject effect;
public void Start(){
    anim = GetComponent<Animator>();
}
    public void Update(){
    Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;
    if (playerInput == Vector3.zero)
            {
                anim.SetBool("isRunning", false);
            }
            else
                anim.SetBool("isRunning", true);
            }
}