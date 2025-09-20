using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("total_coins", PlayerPrefs.GetInt("total_coins", 0) + 1);
            Destroy(this.gameObject);
        }
    }
}
