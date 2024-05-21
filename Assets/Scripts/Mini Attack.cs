using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MiniAttack : MonoBehaviour
{
  
    public Animator playerAnim;
    public float attackDelay;
    public Transform weaponTransform;
    public float weaponRange;
    public int weaponDamage;
    public LayerMask enemyLayer;

    public float timer;
    private float coolDown = 0.8f;
    public float Kbforce;

    public float speed = 5f;



    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && timer <= 0) {
            StartCoroutine(Attack1());
            timer = coolDown;
        }
    }
    IEnumerator Attack1()
    {
        playerAnim.Play("Swordslash");
        Collider2D enemy= Physics2D.OverlapCircle(weaponTransform.position, weaponRange, enemyLayer);
        yield return new WaitForSeconds(attackDelay);
        bool facingRight =(transform.position.x < enemy.transform.position.x);
        enemy.GetComponent<MiniPlayer2>().TakeDamage(weaponDamage,facingRight,Kbforce);

    }
     public void FixedUpdate(){
    Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;
    if (playerInput == Vector3.zero)
            {
                playerAnim.SetBool("isRunning", false);
            }
            else
                playerAnim.SetBool("isRunning", true);
            }
}
