using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTalkingScript2 : MonoBehaviour
{
    public GameObject selectpanel;        //トーク話題を選択するパネル
    public GameObject talkpanel;          //この会話パネル自身

    public Text talk2;      //このテキストオブジェクトそのもの

    private int count = 0;          //1セリフにつき1ずつ上昇。MAXに到達したらcountを0に戻し、トーク話題選択へ戻る

    // Start is called before the first frame update
    void Start()
    {
        talk2.text = "美味いちくわ料理について聞きたいのかい？いいだろう。";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && count == 0){
            talk2.text = "まずおすすめはマヨネーズ和えだな。あの絶妙な味のマッチングは最高だ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 1){
            talk2.text = "次におでんだ。あの出汁が染みたちくわを日本酒と合わせて食った日には美味さのあまりにストレスと理性が惑星外まで吹っ飛んじまうよ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 2){
            talk2.text = "あとはチーチクだな。チーズの濃厚な美味さが口の中でちくわと絡み合って最高に美味いんだなこれが。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 3){
            talk2.text = "ざっとこんなもんかな。他にも煮るなり焼くなりいろんな調理方法があるからな。調べて色々な料理をしてみてくれ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 4){
            talk2.text = "にしてもどう調理しても美味いなんて、我ながら最高の食材だな。はっはっは。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 5){
            talk2.text = "...";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 6){
            talk2.text = "ここ笑うとこだぞ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 7){
            count = 0;
            talk2.text = "美味いちくわ料理について聞きたいのかい？いいだろう。";
            selectpanel.SetActive(true);
            talkpanel.SetActive(false);
        }
    }
}
