using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void MovetoScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
