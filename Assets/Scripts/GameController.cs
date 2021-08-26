using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        }
    }

    void SetGameOver(){
        
    }
}
