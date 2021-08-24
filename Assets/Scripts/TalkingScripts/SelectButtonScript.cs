using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButtonScript : MonoBehaviour
{
    public GameObject selectpanel;
    public GameObject talk1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TalkPanelOn(){
        talk1.SetActive(true);      //ボタンが押されると表示
        selectpanel.SetActive(false);     //ボタンが押されると選択パネルを非表示
    }

}
