using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class minicharhealth : MonoBehaviour
{
    // Start is called before the first frame update   public Text healthbar;
       public Text healthbar2;
    private float playerHealth = 30;
    public Rigidbody2D playerRb2;
    public float delayTime2 = .15f;
    private Animator camAnim;

    [SerializeField] private AudioSource hurtsound2;
    private void Start()
    {
           camAnim = GameObject.FindWithTag("MainCamera").GetComponent<Animator>();
            playerRb2 = GetComponent<Rigidbody2D>();
    }
    public void TakeDamage(int amount2, bool facingRight2, float Kbforce2)
    {
        camAnim.Play("Shake");
        int attack1p1, accuracyp1 = 70;

        //For KnockBack Effect
        attack1p1 = Random.Range(0,100);
         if(attack1p1 <= accuracyp1){
        if(facingRight2){
            playerRb2.AddForce(Vector2.left * Kbforce2, ForceMode2D.Impulse);
        }
        else {
            playerRb2.AddForce(Vector2.right * Kbforce2, ForceMode2D.Impulse);
        }
        Debug.Log("Attack Success");
        }
        else {
        Debug.Log("Attack Missed");
         }

        //For Damage
        hurtsound2.Play();
        playerHealth -= amount2;
        healthbar2.GetComponent<UnityEngine.UI.Text>().text = playerHealth.ToString();
        if(playerHealth <= 0) {
            StartCoroutine(Wait());
        }
        StartCoroutine(Delay());
        

    }
    IEnumerator Delay(){
        yield return new WaitForSeconds(delayTime2);
        playerRb2.velocity = Vector2.zero;
    }



    IEnumerator Wait(){
        yield return new WaitForSeconds(delayTime2);
        Destroy(gameObject);
        SceneManager.LoadScene("player1win");
    }
}
