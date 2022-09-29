using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro;



public class DetectorMeta : MonoBehaviour
{
   [SerializeField]
    GameObject pantallaFinal;


    [SerializeField]
    TextMeshProUGUI textTiempoTotal;
    TextMeshProUGUI textNumeroMonedas;

float tiempodePartida = 0.0f;
bool estaJugando = true;

private void Update()
{
    if (estaJugando == true)
    {

        tiempodePartida = tiempodePartida + Time.deltaTime;
    }


}

   private void OnTriggerEnter(Collider other)
   {

    if (other.tag == "Player")
    {

        
        pantallaFinal.SetActive(true);
        other.GetComponent<MovimientoJugador>().enabled = false;
        estaJugando = false;
        textTiempoTotal.text = tiempodePartida.ToString();
        textNumeroMonedas.text = tiempodePartida.ToString();
    }


   }




}
