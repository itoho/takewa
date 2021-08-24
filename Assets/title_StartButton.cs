using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移させる場合に必要
public class title_StartButton : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField, HeaderAttribute ("タイトルサウンド")] AudioClip sound;
    [SerializeField, HeaderAttribute ("オーディオソース")] AudioSource source;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/* タップされたら音を鳴らし、ステージ選択シーンに移行する。この関数はタップされると呼び出される*/
    public void on_Click(){
        source.PlayOneShot(sound,4.0f);//シーン遷移でボタンごと消えるから意味ないけど一応残しといた
        SceneManager.LoadScene("stage_choice");
    }
}
