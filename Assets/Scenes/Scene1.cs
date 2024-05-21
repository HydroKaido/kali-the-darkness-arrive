using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Scene1 : MonoBehaviour
{
public static Scene1 scenea;
public TMP_InputField inputField;
public string player1_name;

private void Awake(){
    if(scenea == null){
        scenea = this;
        DontDestroyOnLoad(gameObject);
    }
    else 
    {
        Destroy(gameObject);
    }
}
public void setplayer1name()
{
    player1_name = inputField.text;

    SceneManager.LoadSceneAsync("Scene2");
}
}
