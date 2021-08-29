using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
       GameOverPanel.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Indicate(){
       GameOverPanel.SetActive(true); 
    }
    public void Retry(){
        SceneManager.LoadScene("TikuwaAction");
    }
    public void Return(){
        SceneManager.LoadScene("MenuScene");
    }
}
