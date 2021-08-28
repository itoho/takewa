using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移させる場合に必要
public class Stageselectbutton : MonoBehaviour
{
    // Start is called before the first frame update

    public string stagename;//読み込むシーン名の設定
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick(){
        SceneManager.LoadScene(stagename);
    }
}
