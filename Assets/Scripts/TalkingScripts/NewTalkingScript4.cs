using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTalkingScript4 : MonoBehaviour
{
    public GameObject selectpanel;        //トーク話題を選択するパネル
    public GameObject talkpanel;          //この会話パネル自身

    public Text talk4;      //このテキストオブジェクトそのもの

    private int count = 0;          //1セリフにつき1ずつ上昇。MAXに到達したらcountを0に戻し、トーク話題選択へ戻る

    // Start is called before the first frame update
    void Start()
    {
        talk4.text = "ちくわにまつわる開発者の面白い話かぁ•••。";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && count == 0){
            talk4.text = "ううむ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 1){
            talk4.text = "そういえば風の噂で聞いたんだが、";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 2){
            talk4.text = "このゲームの開発者の一人である「ひじき」とかいう奴が中学生のときに、";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 3){
            talk4.text = "おでんに入ってるちくわを食べるときに何を思ったのか、急にちくわを使ってアッツアツのおでんの汁をストローの要領で吸い出して";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 4){
            talk4.text = "あまりの熱さにゴボボボッっていう音ともにおでんの汁を吐き出して口全体にやけど負ったらしい";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 5){
            talk4.text = "普通の人間なら危険なのわかるだろ•••。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 6){
            talk4.text = "アホすぎて俺は未だに作り話だと思っているぞ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 7){
            talk4.text = "みんなはちゃんとちくわをストロー代わりにせずおでんを、食べようね！";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 8){
            count = 0;
            talk4.text = "ちくわにまつわる開発者の面白い話かぁ•••。";
            selectpanel.SetActive(true);
            talkpanel.SetActive(false);
        }
    }
}
