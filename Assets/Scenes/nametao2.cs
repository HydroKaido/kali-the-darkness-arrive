using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class nametao2 : MonoBehaviour
{
    // Start is called before the first frame updatepublic TextMeshProUGUI displayplayer1;
public TextMeshProUGUI displayplayer1;
public TextMeshProUGUI displayplayer2;


public void Awake(){
    displayplayer1.text = NameTao.scenea.player1_name;
    displayplayer2.text = nametao1.sceneb.player2_name;
    }
}
