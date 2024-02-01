using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales4 : MonoBehaviour
{
    public int numero = 15;

    void Start()
    {
        if (numero > 10)
        {
            string caso1 = numero + "es mayor a 10";
            Debug.Log(caso1);
        }
        else if (numero < 10)
        {
            string caso2 = numero + "es menor a 10";
            Debug.Log(caso2);
        }
        else if (numero == 10)
        {
            string caso3 = numero + "es igual a 10";
            Debug.Log(caso3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
