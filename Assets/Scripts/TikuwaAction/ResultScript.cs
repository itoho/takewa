using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour
{
    int result;
    public Text resultText;
    public GameObject counttext;
    CountText script;
    // Start is called before the first frame update
    void Start()
    {
       counttext = GameObject.Find("Counttext");
       script = counttext.GetComponent<CountText>();
    }

    // Update is called once per frame
    void Update()
    {
        result = script.score;
        resultText.text = "SCORE: " + result;
    }
}
