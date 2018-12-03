using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class resultscript : MonoBehaviour {

    public TextMeshProUGUI resulttext;

    void Start()
    {
        //resulttext.text = PlayerPrefs.GetString("winner");
    }

    void Update () {
        Debug.Log("result1111");
        Debug.Log(PlayerPrefs.GetString("winner"));
        Debug.Log(PlayerPrefs.GetInt("winnervalue"));
        resulttext.text = PlayerPrefs.GetString("winner") + " " + PlayerPrefs.GetInt("winnervalue").ToString();
	}

    
}
