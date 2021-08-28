using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
   [Header("攻撃オブジェクト")] public GameObject Bullet;
   [Header("攻撃オブジェクト2")] public GameObject Bullet3;
    [Header("攻撃間隔")] public float interval; 

    public float timer;     //時間計測
    public int rnd;        //乱数

    // Start is called before the first frame update
    void Start()
    {
        Bullet.SetActive(false);
        Bullet3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
    rnd = Random.Range(1, 11);　// ※ 1～10の範囲でランダムな整数値が返る
        if(timer > interval){
            timer = 0.0f;
            Attack();
        }else{
            timer += Time.deltaTime;
        }
    }

    public void Attack(){
    if(rnd<=5){
        Debug.Log("発射");
        GameObject Bullet2 = Instantiate(Bullet);
        Bullet2.transform.SetParent(transform);
        Bullet2.transform.position = Bullet.transform.position;
        Bullet2.transform.rotation = Bullet.transform.rotation;
        Bullet2.SetActive(true);
    }else{
        Debug.Log("発射");
        GameObject Bullet4 = Instantiate(Bullet3);
        Bullet4.transform.SetParent(transform);
        Bullet4.transform.position = Bullet3.transform.position;
        Bullet4.transform.rotation = Bullet3.transform.rotation;
        Bullet4.SetActive(true);
    }

    }

}
