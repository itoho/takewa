using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboo : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;//速度
    public float height;//振れ幅s

    private Vector2 firstposition;

    private int flame=0;
    private bool up;
    void Start()
    {
        firstposition=this.transform.position;
    }

    // Update is called once per frame
    //上下運動させる
    void Update()
    {
        if (up){
            this.transform.position=new Vector2(this.transform.position.x,this.transform.position.y+speed);
        }else{
            this.transform.position=new Vector2(this.transform.position.x,this.transform.position.y-speed);
        }
        if (this.transform.position.y- firstposition.y >height){
            up=false;
        }
        if (firstposition.y-this.transform.position.y>height){
            up=true;
        }
    }
}
