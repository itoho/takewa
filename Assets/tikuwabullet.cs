using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tikuwabullet : MonoBehaviour
{
    [Header("スピード")] public float speed;
    [Header("最大移動距離")] public float maxDistance;
    [Header("左方向へ行かせるスイッチ")]public bool leftswitch = false;

    private Rigidbody2D rb2d;
    private Vector2 defaultPos;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        defaultPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float d = Vector2.Distance(transform.position, defaultPos);

    if(leftswitch){
        if(d > maxDistance){
            Destroy(this.gameObject);
        }else{
            rb2d.MovePosition(transform.position -= transform.right * Time.deltaTime * speed);            
        }
    }else{
        if(d > maxDistance){
            Destroy(this.gameObject);
        }else{
            rb2d.MovePosition(transform.position += transform.right * Time.deltaTime * speed);            
        }
    }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         Destroy(this.gameObject);
    }

}
