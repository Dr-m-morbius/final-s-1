using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ui : MonoBehaviour
{
    public TextMeshProUGUI CoinAmount; 
    // Start is called before the first frame update
    void Start()
    {
        CoinAmount.text = "coins: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
