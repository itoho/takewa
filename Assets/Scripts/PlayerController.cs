using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidBody;//rigidbodyのオブジェクト
    [SerializeField] GameObject gamemaster;//ゲームマスターのオブジェクト
    private GameController gamemasterscript;//ゲームマスターのスクリプト(ゲームオーバー変数書き換えよう)
    public float dashpower;//移動速度
    public float jumppower;//ジャンプパワー
    [SerializeField] bool jumpflag;//ジャンプ中かそうでないか
    private bool lastjumpflag;//直前にジャンプしていたら２段ジャンプをキャンセルする

    public float footposition;//足のx位置


    public LayerMask groundlayer;   //グラウンドレイヤー
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();//スタート時にrigitbodyを取得する
        gamemasterscript=gamemaster.GetComponent<GameController>();//Gamemasterの中にあるGameControllerスクリプトの取得
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
            //rigidBody.AddForce(Vector3.left * dashpower, ForceMode2D.Force);
            rigidBody.velocity= new Vector2(-1*dashpower,rigidBody.velocity.y);
        }
        // 右に移動
        if (Input.GetKey (KeyCode.RightArrow)) {
            //rigidBody.AddForce(Vector3.right * dashpower, ForceMode2D.Force);
            rigidBody.velocity =new Vector2(1*dashpower,rigidBody.velocity.y);
        }
        // 上に移動
        if (Input.GetKey (KeyCode.UpArrow)) {
            if(jumpflag&&(!lastjumpflag)){
                rigidBody.velocity = Vector3.up*jumppower;
                lastjumpflag=true;
            }
            lastjumpflag=false;
            //Debug.Log("up");
        }
    }
//*線を下に飛ばしてジャンプ可能かどうかを更新する */
    void jumpcheck(){
        Debug.DrawLine(transform.position+new Vector3(footposition,0),transform.position+new Vector3(footposition,0) - transform.up * 0.52f,Color.white,2.5f);
        jumpflag= Physics2D.Linecast(transform.position+new Vector3(footposition,0),
            transform.position +new Vector3(footposition,0)- transform.up * 0.52f,groundlayer);

    }

    void movecamera(){

    }

    //接触したオブジェクトが引数otherとして渡される
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "void"){
            Debug.Log("drop");
            gamemasterscript.gameover=true;
            
        }
        

    }
}
