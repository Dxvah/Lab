using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField]
    
    TextMeshProUGUI textNumeroMonedas;


    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;
    int monedas = 0;
    private object MonedasTotales;





    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeX = - Input.GetAxis("Horizontal") * Time.deltaTime;
        movimientoEjeZ = - Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }

     void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Meta")
        {
            textNumeroMonedas.text = MonedasTotales.ToString();


        }

        if (other.tag == "Coin")
        {

            other.gameObject.SetActive(false);

        }
    }
}
