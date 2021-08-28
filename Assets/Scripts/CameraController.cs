using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playerObj;//プレイヤーオブジェクト

    Transform playerTransform;
    void Start()
    {
        playerTransform = playerObj.transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    //*x軸だけプレイヤーに追従するようにする */
    void MoveCamera(){
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
    }
}
