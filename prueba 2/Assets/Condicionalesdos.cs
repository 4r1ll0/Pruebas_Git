using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionalesdos : MonoBehaviour
{
    int dinero = 65;
    int masDinero = 70;
    public int alumnos = 100;
    int tercerCaso = 95;
    int cuartoCaso = 4000;

    void Start()
    {
        if (alumnos >= 100)
        {
            int precioTotal = alumnos * dinero;
            Debug.Log("En total se debera pagar" + precioTotal +
                "y cada alumno paga 65 euros");
        }
        else if (alumnos <= 99 && alumnos >= 50)
        {
            int precioFinal = alumnos * masDinero;
            Debug.Log("En total se debera pagar" + precioFinal +
                "y cada alumno paga 70 euros");
        }
        else if (alumnos >= 30 && alumnos <= 49)
        {
            int precioFinal2 = alumnos * tercerCaso;
            Debug.Log("En total se debera pagar" + precioFinal2 +
                "y cada alumno paga 95 euros");
        }
        else if (alumnos < 30)
        {
            int precioFinal3 = alumnos * cuartoCaso;
            int pagacadaAlumno = precioFinal3 / alumnos;
            Debug.Log("En total se debera pagar" + precioFinal3 +
                "y cada alumno paga" + pagacadaAlumno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
