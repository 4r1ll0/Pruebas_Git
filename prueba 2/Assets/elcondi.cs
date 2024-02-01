using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elcondi : MonoBehaviour
{
    public int numero = 20;

    void Start()
    {
        if (numero <= -1)
        {
            string negativo = numero + "es negativo";
            Debug.Log(negativo);
        }
        else if (numero >= 0)
        {
            string positivo = numero + "es positivo";
            Debug.Log(positivo);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
