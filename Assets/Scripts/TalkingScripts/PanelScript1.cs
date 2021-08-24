using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript1 : MonoBehaviour
{
    public GameObject talkpanel;         //このパネル自身

    // Start is called before the first frame update
    void Start()
    {
        talkpanel.SetActive(false);      //ボタンが押されるまでは非表示
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
