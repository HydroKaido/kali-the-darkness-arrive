using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class miniscene2 : MonoBehaviour
{
    // Start is called before the first frame update
public TextMeshProUGUI displayplayer1;
public TextMeshProUGUI displayplayer2;


public void Awake(){
    displayplayer1.text = miniscene.scenea.player1_name;
    displayplayer2.text = miniscene1.sceneb.player2_name;
    }
}
