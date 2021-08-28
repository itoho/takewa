using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifetext : MonoBehaviour
{
    int life = 5;
    public Text lifeText;
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = "LIFE: " + life.ToString();        
    }
    public void ReduceLife(){
        if(life >= 2){
            life--;
        }else{
            life = 0;
            Debug.Log("GameOverです");
            GameOver.SendMessage("Indicate");
        }
    }
}
