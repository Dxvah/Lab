using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    [SerializeField]

    float rotacionY;


    [SerializeField]
    GameObject Coin;

    bool TocarCoin = true;
    float TiempoCoin = 1f;

    private void Update()
    {

        transform.Rotate(0f, rotacionY * Time.deltaTime, 0f);

        if (TocarCoin == false)
        {

            TiempoCoin = TiempoCoin - Time.deltaTime;



        }



        static void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Coin")
            {

                other.gameObject.SetActive(false);

            }
        }

    }
    
   
}
