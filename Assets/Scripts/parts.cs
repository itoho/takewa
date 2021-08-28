using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parts : MonoBehaviour
{
    public GameObject gamemaster;
    private GameController gamemasterscript;//ゲームマスターのスクリプト
    // Start is called before the first frame update
    void Start()
    {
        gamemasterscript=gamemaster.GetComponent<GameController>();//Gamemasterの中にあるGameControllerスクリプトの取得
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag == "Player"){
            gamemasterscript.parts+=1;
            Destroy (this.gameObject);
        }

    }
}
