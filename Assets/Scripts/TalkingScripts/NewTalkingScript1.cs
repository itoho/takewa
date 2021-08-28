using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTalkingScript1 : MonoBehaviour
{

    public GameObject selectpanel;        //トーク話題を選択するパネル
    public GameObject talkpanel;          //この会話パネル自身

    public Text talk1;      //このテキストオブジェクトそのもの

    private int count = 0;          //1セリフにつき1ずつ上昇。MAXに到達したらcountを0に戻し、トーク話題選択へ戻る

    // Start is called before the first frame update
    void Start()
    {
        talk1.text = "ちくわの歴史について聞きたいのかい？いいだろう。";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && count == 0){
            talk1.text = "ちくわは歴史が最も古い食材の一つで、歴史にはかまぼこが大きく関係しているんだ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 1){
            talk1.text = "かまぼこは平安時代から存在していて書物にもしるされているんだ。かまぼこは当時すごい高級だったけど時代が進むにつれて庶民でも食べれるのものになったんだ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 2){
            talk1.text = "その過程でいろんな魚のすり身料理が登場して、もともとのかまぼこと区別するために「ちくわ」と名付けられたんだ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 3){
            talk1.text = "名前の由来は切り口が竹の輪に似ていることからだと言われてるぞ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 4){
            talk1.text = "それはそうと、この竹の輪イカしてるだろ？自分に突き刺すの大変だったしな！";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 5){
            count = 0;
            talk1.text = "ちくわの歴史について聞きたいのかい？いいだろう。";
            selectpanel.SetActive(true);
            talkpanel.SetActive(false);
        }
    }
}
