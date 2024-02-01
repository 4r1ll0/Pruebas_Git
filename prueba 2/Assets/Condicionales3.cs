using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales3 : MonoBehaviour
{
    public string nombre = "Jose";
    public bool sexoHombre = true;
    public int hijos = 3;
    public float precioTotal = 56;

    void Start()
    {
        if (sexoHombre == true && hijos == 0)
        {
            float operacion = precioTotal * (2.5f / 100);
                float resta = precioTotal - operacion;
            Debug.Log("Señor" + nombre + operacion +
                "este es su descuento y" + "su precio final es de" + resta);
        }
        else if (sexoHombre == true && hijos >= 1)
        {
            float operacion2 = precioTotal * (5f / 100);
            float resta2 = precioTotal - operacion2;
            Debug.Log("Señor" + nombre + operacion2 +
                "este es su descuento y" + "su precio final es de" + resta2);
        }
        else if (sexoHombre == false && hijos == 0)
        {
            float operacion3 = precioTotal * (10f / 100);
            float resta3 = precioTotal - operacion3;
            Debug.Log("Señorita" + nombre + operacion3 +
                "este es su descuento y" + "su precio final es de" + resta3);

        }
        else if (sexoHombre == false && hijos >= 1 && hijos <= 2)
        {
            float operacion4 = precioTotal * (15f / 100);
            float resta4 = precioTotal - operacion4;
            Debug.Log("Señora" + nombre + operacion4 +
                "este es su descuento y" + "su precio final es de" + resta4);
        }
        else if (sexoHombre == false && hijos >= 3)
        {
            float operacion5 = precioTotal * (20f / 100);
            float resta5 = precioTotal - operacion5;
            Debug.Log("Señora" + nombre + operacion5 +
                "este es su descuento y" + "su precio final es de" + resta5);
        }
    }
}



       

            
        