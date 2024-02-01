using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operaciones : MonoBehaviour
{
    public int primerNumero = 20;
    public int segundoNumero = 10;

    int chicos = 100;
    int chicas = 150;

    int segundos = 500;

    float milllasMarinas = 5;

    int precioInicial = 30;

    void Start()
    {
        //Ejerccio 1
        int suma = primerNumero + segundoNumero;
        Debug.Log(suma);
        

        //Ejercicio 2
        int multiplicacion = primerNumero * segundoNumero;
        Debug.Log(multiplicacion);
        

        //Ejercicio 4
        int operacion = chicos + chicas;
        float porcentajeChicos =  100 * chicos / operacion;
        float porcentajeChicas = 100 * chicas / operacion;
        Debug.Log(porcentajeChicas);
        Debug.Log(porcentajeChicos);
        

        //Ejercicio 5
        int minutos = segundos / 60;
        int segundosResto = segundos % 60;
        int horas = minutos / 60;
        Debug.Log("Los segundos son "
            + segundosResto + " los minutos " + minutos 
            + " y las horas " + horas);
        

        //Ejercicio 6
        float metros = milllasMarinas * 1852;
        Debug.Log(metros);
        

        //Ejercicio 8
        int descuento = precioInicial * 10 / 100;
        int precioFinal = precioInicial - descuento;
        Debug.Log(precioInicial);
        Debug.Log(precioFinal);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
