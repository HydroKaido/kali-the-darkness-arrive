using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleaseDestroy : MonoBehaviour
{
    void Start () {
         Destroy (GameObject.Find("SceneManager"));
         Destroy (GameObject.Find("SceneManger"));
     }
}
