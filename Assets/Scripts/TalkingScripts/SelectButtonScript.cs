using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButtonScript : MonoBehaviour
{
    public GameObject selectpanel;
    public GameObject talk1;
    public GameObject talk2;
    public GameObject talk3;
    public GameObject talk4;
    public GameObject talk5;
    public GameObject talk6;
	public AudioClip impact;            //音源の指定
    private AudioSource audiosource;    //AudioSourceの宣言


    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();  //AudioSourceの取得          
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TalkPanelOn(){
        audiosource.PlayOneShot(impact);             //SEを鳴らす
        talk1.SetActive(true);      //ボタンが押されると表示
        selectpanel.SetActive(false);     //ボタンが押されると選択パネルを非表示
    }
    public void TalkPanelOn2(){
        audiosource.PlayOneShot(impact);             //SEを鳴らす
        talk2.SetActive(true);      //ボタンが押されると表示
        selectpanel.SetActive(false);     //ボタンが押されると選択パネルを非表示
    }
    public void TalkPanelOn3(){
        audiosource.PlayOneShot(impact);             //SEを鳴らす
        talk3.SetActive(true);      //ボタンが押されると表示
        selectpanel.SetActive(false);     //ボタンが押されると選択パネルを非表示
    }
    public void TalkPanelOn4(){
        audiosource.PlayOneShot(impact);             //SEを鳴らす
        talk4.SetActive(true);      //ボタンが押されると表示
        selectpanel.SetActive(false);     //ボタンが押されると選択パネルを非表示
    }
    public void TalkPanelOn5(){
        audiosource.PlayOneShot(impact);             //SEを鳴らす
        talk5.SetActive(true);      //ボタンが押されると表示
        selectpanel.SetActive(false);     //ボタンが押されると選択パネルを非表示
    }
    public void TalkPanelOn6(){
        audiosource.PlayOneShot(impact);             //SEを鳴らす
        talk6.SetActive(true);      //ボタンが押されると表示
        selectpanel.SetActive(false);     //ボタンが押されると選択パネルを非表示
    }
    public void ReturnMenu(){
        // SceneManager.LoadScene(メニュー画面);
    }

}
