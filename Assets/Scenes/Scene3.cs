using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scene3 : MonoBehaviour
{
public TextMeshProUGUI displayplayer1;
public TextMeshProUGUI displayplayer2;


public void Awake(){
    displayplayer1.text = Scene1.scenea.player1_name;
    displayplayer2.text = scene2.sceneb.player2_name;
    }

}

