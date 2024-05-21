using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class blue : MonoBehaviour
{
    public GameObject spike;
    void OnTriggerEnter(Collider other)
    {
        if (spike ==  other.gameObject.CompareTag("spike"))
        {
            SceneManager.LoadScene("player1win");
        }
    }
}
