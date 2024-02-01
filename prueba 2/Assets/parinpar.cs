using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parinpar : MonoBehaviour
{
    public int numero = 30;

    void Start()
    {
        if (numero % 2 == 0) 
        {
            string par = numero + "es par";
            Debug.Log(par);
        }
        else if (numero % 2 != 0)
        {
            string impar = numero + "es impar";
            Debug.Log(impar);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
