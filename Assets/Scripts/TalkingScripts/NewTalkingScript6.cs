using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTalkingScript6 : MonoBehaviour
{
    public GameObject selectpanel;        //トーク話題を選択するパネル
    public GameObject talkpanel;          //この会話パネル自身

    public Text talk6;      //このテキストオブジェクトそのもの

    private int count = 0;          //1セリフにつき1ずつ上昇。MAXに到達したらcountを0に戻し、トーク話題選択へ戻る

    // Start is called before the first frame update
    void Start()
    {
        talk6.text = "なるほど、開発秘話か。色々あるなぁ。";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && count == 0){
            talk6.text = "まずはなんでテーマを「ちくわ」にしたかだな。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 1){
            talk6.text = "そもそも最初は竹そのものを題材にして、ちくわのカケラ集めて成長させるっていうコンセプトだったんだが、";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 2){
            talk6.text = "いつの間にか竹とちくわが入れ替わって、完全にちくわのゲームになってしまったって感じだな。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 3){
            talk6.text = "あとこのちくわの絵だが、絵担当のメンバーがちくわを描く時にダメ元で「ちくわ　描き方」と調べたら";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 4){
            talk6.text = "クッソ詳しい描き方の情報が載っているサイトがあってめちゃくちゃビビったってのがあるな。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 5){
            talk6.text = "あとは制作途中でメンバーのうちの一人のグラボが壊れたり、タイトルの原案が「竹輪物語」（竹の輪取り物語）だったりと";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 6){
            talk6.text = "沢山話したいことがあるが、今回はこんなもんかな。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 7){
            talk6.text = "まあ、色々あったけど、力を合わせて完成させたこの「ちくわ」。是非、遊び尽くしてくれ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 8){
            count = 0;
            talk6.text = "なるほど、開発秘話か。色々あるなぁ。";
            selectpanel.SetActive(true);
            talkpanel.SetActive(false);
        }
    }
}
