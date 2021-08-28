using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TikuwaAction : MonoBehaviour
{
	public float speed = 3.0f;
    public GameObject scoreObject;
    public GameObject score;
    public GameObject life;
    public int bombcount = 0;
	public AudioClip impact;            //音源の指定
	public AudioClip impact2;            //音源の指定
    private AudioSource audiosource;    //AudioSourceの宣言

    // Start is called before the first frame update
    void Start()
    {
        scoreObject = GameObject.Find("GameObject");
        audiosource = GetComponent<AudioSource>();  //AudioSourceの取得  
    }
	
	// Update is called once per frame
	void Update()
    {
		if (Input.GetKey("right")) {
			transform.position += transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey ("left")) {
			transform.position -= transform.right * speed * Time.deltaTime;
		}
	}

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "parts"){
            Debug.Log("スコアに加点するよ");
            audiosource.PlayOneShot(impact);             //SEを鳴らす
            Destroy (collider.gameObject);
            score.SendMessage("AddScore");
        }
        if(collider.gameObject.tag == "bomb"){
            Debug.Log("爆弾に当たったよ");
            audiosource.PlayOneShot(impact2);             //SEを鳴らす
            Destroy (collider.gameObject);
            life.SendMessage("ReduceLife");
            if(bombcount <= 3){
                bombcount++;
            }else{
                Destroy(this.gameObject);
            }
        }
    }
}
