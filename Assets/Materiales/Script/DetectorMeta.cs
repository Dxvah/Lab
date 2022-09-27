using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorMeta : MonoBehaviour
{
   [SerializeField]
    GameObject pantallaFinal;

   private void OnTriggerEnter(Collider other)
   {

    if (other.tag == "Player")
    {

        Debug.Log("Jugador llegó a la meta");
        pantallaFinal.SetActive(true);
        other.GetComponent<MovimientoJugador>().enabled = false;
    }


   }




}
