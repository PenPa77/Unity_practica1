using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinProgra : MonoBehaviour
{

    public static int countCoins = 0;
    // Start is called before the first frame update
    void Start()
    {
        CoinProgra.countCoins++;
    }

    private void OnDestroy()
    {
        CoinProgra.countCoins--;
        if(CoinProgra.countCoins <=0)
        {
            GameObject timer = GameObject.Find("GameTimer");
            Destroy(timer);
            Debug.Log("El juego ha terminado, has ganado");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Se ha recolectado la moneda #" + CoinProgra.countCoins);
        if(collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
