using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    bool pokedexCompletada = true;
    int numeroMedallas = 10;
    string pokeBall = "Master Ball";

    void Start()
    {
        if (numeroMedallas < 8)
        {
            string mensaje = "error";
            Debug.Log(mensaje);
        }
        else if (numeroMedallas > 8)
        {
            string  mensajeClear = "win";
            Debug.Log(mensajeClear);
            if (pokedexCompletada == true && pokeBall == "Master Ball" )
            {
                string mensajePremio = "Enorabuena";
                Debug.Log(mensajePremio);
            }
            // ¿y si no tengo la pokedex?
            if (pokedexCompletada != true)
            {
                string pokedezIncompleta = "Pokedez Incompleta";
                Debug.Log(pokedezIncompleta);
            }
            // ¿y si no tengo la pokeball?
            if (pokeBall != "Master Ball")
            {
                string noMasterball = "Busca la Master Ball";
                Debug.Log(noMasterball);
            }


        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
