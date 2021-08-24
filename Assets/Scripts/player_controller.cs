using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidBody;//rigidbodyのオブジェクト
    public float dashpower;//移動速度
    public float jumppower;//ジャンプパワー
    [SerializeField] bool jumpflag;//ジャンプ中かそうでないか
    private bool lastjumpflag;//直前にジャンプしていたら２段ジャンプをキャンセルする

    public LayerMask groundlayer;   //グラウンドレイヤー
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();//スタート時にrigitbodyを取得する
    }

    // Update is called once per frame
    void Update()
    {
        jumpcheck();//ジャンプフラグの更新
        move();
        movecamera();
    }
//*自機を動かす関数 */
    void move(){
        //左に移動
        if (Input.GetKey (KeyCode.LeftArrow)) {
            rigidBody.AddForce(Vector3.left * dashpower, ForceMode2D.Force);
        }
        // 右に移動
        if (Input.GetKey (KeyCode.RightArrow)) {
            rigidBody.AddForce(Vector3.right * dashpower, ForceMode2D.Force);
        }
        // 上に移動
        if (Input.GetKey (KeyCode.UpArrow)) {
            if(jumpflag&&(!lastjumpflag)){
                rigidBody.AddForce(Vector3.up * jumppower, ForceMode2D.Force);
                lastjumpflag=true;
            }
            lastjumpflag=false;
            //Debug.Log("up");
        }
    }
//*線を下に飛ばしてジャンプ可能かどうかを更新する */
    void jumpcheck(){
        Debug.DrawLine(transform.position,transform.position - transform.up * 0.52f,Color.white,2.5f);
        jumpflag= Physics2D.Linecast(transform.position,
            transform.position - transform.up * 0.52f,groundlayer);

    }

    void movecamera(){

    }
}
