using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
// LIFE 
 [Range(0,1)]
public float healthValue = 100f;
[SerializeField] Image foreground = null;



public Button lowpunchbutton;
public Button highpunchbutton;
public Button lowkickbutton;
public Button highkickbutton;
public Button Specialbutton;
public GameObject healthtext;
public void start()
{
     lowpunchbutton.onClick.AddListener(lowpunch);
     highpunchbutton.onClick.AddListener(highpunch);
     lowkickbutton.onClick.AddListener(lowkick);
     highkickbutton.onClick.AddListener(highkick);
     Specialbutton.onClick.AddListener(special);
}

public void Update()
{
   healthtext.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = foreground.ToString() + "%";

}

public void lowpunch(){
    int attack1p1, accuracyp1 = 75;
    attack1p1 = Random.Range(0,100);
     if(attack1p1 <= accuracyp1){
    healthValue -= 3f;
    foreground.fillAmount = healthValue;
    Debug.Log("Attack Success");
     }
     else{
        Debug.Log("Attack Missed");
     }

     if(healthValue <=0)
     {
        healthValue = 0;
        SceneManager.LoadScene(1);
     }

    }


public void highpunch(){
    int attack2p1, accuracyp2 = 55;
    attack2p1 = Random.Range(0,100);
     if(attack2p1 <= accuracyp2){
     healthValue -= 8f;
    foreground.fillAmount = healthValue;
    Debug.Log("Attack Success");
     }
     else{
        Debug.Log("Attack Missed");
     }
   if(healthValue <=0)
     {
        healthValue = 0;
        SceneManager.LoadScene(1);
     }
}

public void lowkick(){
     int attack3p1, accuracyp3 = 65;
    attack3p1 = Random.Range(0,100);
    if(attack3p1 <= accuracyp3){
    healthValue -= 6f;
    foreground.fillAmount = healthValue;
    Debug.Log("Attack Success");
    }
    else
    {
     Debug.Log("Attack Missed");
    }
   if(healthValue <=0)
     {
        healthValue = 0;
       SceneManager.LoadScene(1);
     }
}

public void highkick(){
     int attack4p1, accuracyp4 = 45;
    attack4p1 = Random.Range(0,100);
    if(attack4p1 <= accuracyp4){
    healthValue -= 12f;
    foreground.fillAmount = healthValue;
    Debug.Log("Attack Success");
    }
    else 
    {
       SceneManager.LoadScene(1);
    }
   if(healthValue <=0)
     {
        healthValue = 0;
        Debug.Log("You're Dead");
     }
}

public void special(){
    healthValue -= 25f;
    foreground.fillAmount = healthValue;
    Debug.Log("Attack Success");
       if(healthValue <=0)
     {
        healthValue = 0;
        SceneManager.LoadScene(1);
     }
}

public void update(){
}
}
