using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{

  [SerializeField] public GameObject PauseMenuPanel;

public void Pause(){
    PauseMenuPanel.SetActive(true);
    Time.timeScale = 0f;
}

public void Resume(){
    PauseMenuPanel.SetActive(false);
    Time.timeScale = 1f;
}
public void Restart(){
    Time.timeScale =1f;
    SceneManager.LoadScene("Mini Game");
}
public void Quit(){
    Time.timeScale =1f;
    SceneManager.LoadScene("Mode");
}
}

