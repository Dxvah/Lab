using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColisionPared : MonoBehaviour
{
    [SerializeField]
     Material   materialParedPorDefecto;

    [SerializeField]
     Material   materialParedColision;

    bool paredRoja = false;

    float timeRojo = 5f;

    private void Update()
    {

        if(paredRoja == true)
        {
            timeRojo = timeRojo - Time.deltaTime;
            if (timeRojo < 0.0f)
            {

            gameObject.GetComponent<MeshRenderer>().material = materialParedPorDefecto;
            paredRoja = false;
            timeRojo = 5f;


            }
           



        }



    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {

            gameObject.GetComponent<MeshRenderer>().material = materialParedColision;
            paredRoja = true;



        }


    }





}
