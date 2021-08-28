using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour
{
    public Rigidbody rb;
    public bool rendered = false;//カメラに映っているか判定する変数
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rendered == true)//もしRenderedがtrueなら、
        {
            transform.position += Vector3.left * 0.004f;
        }
        
    }

    void OnWillRenderObject()//カメラに映ってる間に呼ばれ続ける処理
    {
            rendered = true;//Renderedをtrueにする
    }
}
