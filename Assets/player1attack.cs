using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1attack : MonoBehaviour
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
                 if (Input.GetButtonDown("Jump") && isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            }

        timer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && timer <= 0) {
            StartCoroutine(Attack1());
            timer = coolDown;
        }


    }
    IEnumerator Attack1()
    {
        playerAnim.Play("Swordslash2");
        Collider2D enemy= Physics2D.OverlapCircle(weaponTransform.position, weaponRange, enemyLayer);
        yield return new WaitForSeconds(attackDelay);
        bool facingRight =(transform.position.x < enemy.transform.position.x);
        enemy.GetComponent<minicharhealth>().TakeDamage(weaponDamage,facingRight,Kbforce);

    }
     public void FixedUpdate(){
    Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;
    if (playerInput == Vector3.zero)
            {
                playerAnim.SetBool("Running", false);
            }
            else
                playerAnim.SetBool("Running", true);
            }
}
