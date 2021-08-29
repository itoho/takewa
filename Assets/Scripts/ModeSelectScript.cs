using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModeSelectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void go_course(){
        SceneManager.LoadScene("stage_choice");
    }
    public void go_scoreattack(){
        SceneManager.LoadScene("HowToPlay");
    }
    public void go_talking(){
        SceneManager.LoadScene("Talking");
    }    
}
