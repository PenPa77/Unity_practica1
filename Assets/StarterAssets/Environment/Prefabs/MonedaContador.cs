using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedaContador : MonoBehaviour
{
    public Text moneda;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneda.text = "Monedas: " + CoinProgra.countCoins;
    }
}
