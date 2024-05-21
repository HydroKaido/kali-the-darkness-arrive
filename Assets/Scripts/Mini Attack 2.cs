using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniAttack2 : MonoBehaviour
{
    public Animator playerAnim2;
    public float attackDelay2;
    public Transform weaponTransform2;
    public float weaponRange2;
    public int weaponDamage2;
    public LayerMask enemyLayer2;

    public float timer2;
    private float coolDown2 = 1f;
    public float Kbforce2;

    public float speed = 5f;



    // Update is called once per frame
    void Update()
    {
        timer2 -= Time.deltaTime;
        if(Input.GetButton("Fire2") && timer2 <= 0) {
            StartCoroutine(Attack2());
            timer2 = coolDown2;
        }


    }

    //Attack
    IEnumerator Attack2()
    {
        playerAnim2.Play("Swordslash2");
        Collider2D player= Physics2D.OverlapCircle(weaponTransform2.position, weaponRange2, enemyLayer2);
        yield return new WaitForSeconds(attackDelay2);
        bool facingRight2 =(transform.position.x < player.transform.position.x);
        player.GetComponent<MiniPlayer1>().TakeDamage(weaponDamage2,facingRight2,Kbforce2);
    }
    //Walk
    public void FixedUpdate(){
            Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal1"), Input.GetAxisRaw("Vertical1"));
            transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;
    if (playerInput == Vector3.zero)
            {
                playerAnim2.SetBool("Running", false);
            }
            else
                playerAnim2.SetBool("Running", true);
    }



}
