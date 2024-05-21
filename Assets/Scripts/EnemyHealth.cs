using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{

    public Text healthbar;
    public float enemyHealth = 30f;
    public Rigidbody2D enemyRb;
    public float delayTime = .15f;
    private Animator camAnim;

    [SerializeField] private AudioSource hurtsound;
    private void Start()
    
    {
        camAnim = GameObject.FindWithTag("MainCamera").GetComponent<Animator>();
        enemyRb = GetComponent<Rigidbody2D>();
    }
    public void TakeDamage(float amount, bool facingRight, float Kbforce)
    {
        camAnim.Play("Shake");
        
        int attack1p1, accuracyp1 = 70;
        attack1p1 = Random.Range(0,100);

         if(attack1p1 <= accuracyp1){
        if(facingRight){
            enemyRb.AddForce(Vector2.right * Kbforce, ForceMode2D.Impulse);
        }
        else {
            enemyRb.AddForce(Vector2.left * Kbforce, ForceMode2D.Impulse);
        }
            Debug.Log("Attack Success");
     }
        else {
        Debug.Log("Attack Missed");
     }

        enemyHealth -= amount;
        hurtsound.Play();
        healthbar.GetComponent<UnityEngine.UI.Text>().text = enemyHealth.ToString();

        if(enemyHealth <= 0) {
            StartCoroutine(Wait());
        }
        StartCoroutine(Delay());



    }

    IEnumerator Delay(){
        yield return new WaitForSeconds(delayTime);
        enemyRb.velocity = Vector2.zero;
    }

        IEnumerator Wait(){
        
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        SceneManager.LoadScene("MaktanWin");
        }

}
