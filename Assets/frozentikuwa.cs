using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frozentikuwa : MonoBehaviour
{
    [Header("攻撃オブジェクト")] public GameObject Bullet;
    [Header("攻撃間隔")] public float interval; 

    public float timer;     //時間計測

    // Start is called before the first frame update
    void Start()
    {
        Bullet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > interval){
            timer = 0.0f;
            Attack();
        }else{
            timer += Time.deltaTime;
        }
    }

    public void Attack(){
        Debug.Log("発射");
        GameObject Bullet2 = Instantiate(Bullet);
        Bullet2.transform.SetParent(transform);
        Bullet2.transform.position = Bullet.transform.position;
        Bullet2.transform.rotation = Bullet.transform.rotation;
        Bullet2.SetActive(true);
    }

}
