using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculos : MonoBehaviour
{
    int primerNumero = 20;
    int segundoNumero = 30;

    // Start is called before the first frame update
    void Start()
    {
        //int suma = primerNumero + segundoNumero;
        //Debug.Log(suma);


        Debug.Log("Primer valor " + primerNumero);



        int suma = primerNumero + 30;


        Debug.Log ("Segundo valor, tras la primera suma! " + primerNumero);

        // primeroNumero = 50
        // segundoNumero = 30 
        primerNumero =  primerNumero + segundoNumero;
        // primerNumero = 50 + 30

        // "Hola" + "Adios" -> "HolaAdios"
        // CONCATENAR STRING
        Debug.Log("Tercer y último valor " + primerNumero);

        Debug.Log("Hola" + "Adios");

    }

    // Update is called once per frame
    void Update()
    {
         //int suma = primerNumero + segundoNumero;
        //Debug.Log(suma);
    }
}
