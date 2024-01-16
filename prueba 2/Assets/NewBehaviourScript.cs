using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //*Variable que representa la vida dal personaje int es el tipo
    //de variable que es vida es el nombre para identificar esa varable
    //y el 50 es el valor que se le da. 

  
    public int vida = 50;
    public string jugador = "Meca";
     

    void Start()
    {
        //Debug.Log("Bienvenidos a Unity");
        string mensaje_empieza_la_partida = "FIGHT";
        Debug.Log(mensaje_empieza_la_partida);

        mensaje_empieza_la_partida = "FATALITY";
        Debug.Log(mensaje_empieza_la_partida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
