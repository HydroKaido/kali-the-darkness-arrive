using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class p2next : MonoBehaviour
{
    // Start is called before the first frame update   public int health2 = 100;
    
   public GameObject objectfindnamered;

   public GameObject objectfindnameblue;
     [SerializeField] private AudioSource hurtsound2;
    void OnCollisionEnter2D(Collision2D collision)
   {

hurtsound2.Play();
     if(collision.gameObject == objectfindnameblue){
      StartCoroutine(TimerforScene());

     }
hurtsound2.Play();
     if(collision.gameObject ==objectfindnamered) {
       StartCoroutine(TimerforScene1());
     }
   }

   IEnumerator TimerforScene(){
    yield return new WaitForSeconds(1);
    SceneManager.LoadScene("player2win");
    
   }

    IEnumerator TimerforScene1(){
    yield return new WaitForSeconds(1);
    SceneManager.LoadScene("player1win");
    
   }
}
