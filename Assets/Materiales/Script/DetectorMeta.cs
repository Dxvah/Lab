using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    public object MonedasTotales { get; private set; }

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
        textNumeroMonedas.text = MonedasTotales.ToString();
        }


   }




}
