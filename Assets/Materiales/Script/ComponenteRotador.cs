using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ComponenteRotador : MonoBehaviour
{

    [SerializeField]

    float rotacionY;

    
    void Update()
    {
        
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0f);



    }
}
