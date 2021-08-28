using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gamemaster;
    private GameController gamemasterscript;//ゲームマスターのスクリプト
    public TextMeshProUGUI cardNameText;
    void Start()
    {
        gamemasterscript=gamemaster.GetComponent<GameController>();//Gamemasterの中にあるGameControllerスクリプトの取得
    }

    // Update is called once per frame
    void Update()
    {
        cardNameText.text="x "+gamemasterscript.parts;
    }
}
