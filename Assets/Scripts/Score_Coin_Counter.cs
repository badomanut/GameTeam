using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Coin_Counter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI total_coins_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        total_coins_text.text = PlayerPrefs.GetInt("total_coins", 0).ToString("00");
    }
}
