using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //シーン遷移させる場合に必要
public class GameController : MonoBehaviour
{
    public bool gameover=false;//ゲームオーバーならTrue
    public GameObject gameoverPanel;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover){
            gameoverPanel.SetActive(true); 
            if (Input.GetKey (KeyCode.Space)) {
                SceneManager.LoadScene("stage01");
            }
        }
    }

    
}
