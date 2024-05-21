using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textscreen : MonoBehaviour
{


   public GameObject HpText;
   
    //Just something I want print with the Text (don't worry about this
    public float speed;
    public int velocity = 10;
 
    //This is supposedly how I get the text
    private Text UIText;
 
 
    private void Awake()
    {

       //This is supposedly calling the component
        UIText = HpText.GetComponent<Text>();
    }
 
    void Update()
    {
     
        //Prints the Current health of the player also doesn't work
        UIText.text = speed + "/hp";
    }
}
