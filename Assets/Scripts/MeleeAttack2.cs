using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack2 : MonoBehaviour
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

    private Vector3 playerInput;
    bool flipped;
    Rigidbody2D rb;
    [SerializeField] int jumpPower;
    private Animator anim;

    public Transform groudnCheck;
    public LayerMask groundLayer;
    bool isGrounded;


        void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics2D.OverlapCapsule(groudnCheck.position, new Vector2(1.8f, 0.3f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        timer2 -= Time.deltaTime;
        if(Input.GetButton("Fire2") && timer2 <= 0) {
            StartCoroutine(Attack2());
            timer2 = coolDown2;
        }

            Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal1"), Input.GetAxisRaw("Vertical1"));
    transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;
            if (playerInput == Vector3.zero)
            {
                playerAnim2.SetBool("Running", false);
            }
            else {
                playerAnim2.SetBool("Running", true);
            }

            if(playerInput.x > 0)
                {
                    flipped = true;
                    this.transform.localScale = new Vector3(-1f, 1f, 1f);
                }

            else if(playerInput.x < 0)
                {
                    flipped = false;
                    this.transform.localScale = new Vector3(1f, 1f, 1f);
                }

                
        //Jump
        if (Input.GetButtonDown("Jump1") && isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            }
    }
    IEnumerator Attack2()
    {
        playerAnim2.Play("Swordslash2");
        Collider2D player= Physics2D.OverlapCircle(weaponTransform2.position, weaponRange2, enemyLayer2);
        yield return new WaitForSeconds(attackDelay2);
        bool facingRight2 =(transform.position.x < player.transform.position.x);
        player.GetComponent<EnemyHealth2>().TakeDamage(weaponDamage2,facingRight2,Kbforce2);
    }

         public void FixedUpdate(){

         }
}
