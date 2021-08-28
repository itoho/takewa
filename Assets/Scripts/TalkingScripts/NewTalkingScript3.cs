using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTalkingScript3 : MonoBehaviour
{
    public GameObject selectpanel;        //トーク話題を選択するパネル
    public GameObject talkpanel;          //この会話パネル自身

    public Text talk3;      //このテキストオブジェクトそのもの

    private int count = 0;          //1セリフにつき1ずつ上昇。MAXに到達したらcountを0に戻し、トーク話題選択へ戻る

    // Start is called before the first frame update
    void Start()
    {
        talk3.text = "今回出てきた敵ちくわについて聞きたいのか？いいだろう。";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && count == 0){
            talk3.text = "まずは常に体が炎上している「焼きちくわ」だ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 1){
            talk3.text = "ただでさえ焼かれているのにさらに焼かれに行くというまさにドMの鑑だ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 2){
            talk3.text = "次に体がアホみたいに冷えっ冷えになっている「冷凍ちくわ」だ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 3){
            talk3.text = "あまりにも冷えているせいで冷気が纏えるようになり、その冷気で相手を攻撃することができるぞ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 4){
            talk3.text = "ちなみにこの2体はちくわの保存方法をみたときにいいじゃんと思ってそのまんま敵キャラにしたぞ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 5){
            talk3.text = "最後に、なんか気持ち悪い動きをする「バウンドちくわ」だ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 6){
            talk3.text = "こいつは謎の動きでプレイヤーを妨害するためにイヤラシ要員でブチ込んだぞ。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 7){
            talk3.text = "時間がなくて今回はこの３体しか実装出来なかったが、アクションモード、是非楽しんでくれよな。";
            count++;
        }else if(Input.GetMouseButtonDown(0) && count == 8){
            count = 0;
            talk3.text = "今回出てきた敵ちくわについて聞きたいのか？いいだろう。";
            selectpanel.SetActive(true);
            talkpanel.SetActive(false);
        }
    }
}
