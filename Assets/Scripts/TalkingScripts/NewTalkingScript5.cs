using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTalkingScript5 : MonoBehaviour
{
    public GameObject selectpanel;        //トーク話題を選択するパネル
    public GameObject talkpanel;          //この会話パネル自身

    public Text talk5;      //このテキストオブジェクトそのもの

    private int count = 0;          //1セリフにつき1ずつ上昇。MAXに到達したらcountを0に戻し、トーク話題選択へ戻る

    // Start is called before the first frame update
    void Start()
    {
        talk5.text = "なるほど、ちくわの種類か。";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && count == 0){
            talk5.text = "実はお前の思っている以上にちくわってのは種類があってだな。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 1){
            talk5.text = "例えば、牡丹焼きという独自の製法で作られる青森県の「牡丹ちくわ」。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 2){
            talk5.text = "普通とは違い、すり身を用いない愛媛県の「皮ちくわ」。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 3){
            talk5.text = "歯車のようなフォルムをした、ちくわぶの原型とも言われる千葉県の「白ちくわ 」。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 4){
            talk5.text = "他にも岡山県の「豆ちくわ」、愛知県の「豊橋ちくわ」、島根県の「野焼きちくわ」など、本当にたくさんのちくわがあるんだ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 5){
            talk5.text = "ちなみに俺のフォルムは徳島県の「竹ちくわ」を参考にして作られたらしいぞ！（以上、参考文献:Wikipedia）";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 6){
            talk5.text = "みんなも色んなちくわをたくさん食べて、ちくわマスターになろうぜ！（謎理論）";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 7){
            count = 0;
            talk5.text = "なるほど、ちくわの種類か。";
            selectpanel.SetActive(true);
            talkpanel.SetActive(false);
        }
    }
}
