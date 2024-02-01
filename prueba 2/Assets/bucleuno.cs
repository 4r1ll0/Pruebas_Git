using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucleuno : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if(condicion)
        //for(variable;condicion;operacion)
        for(int i = 5; i > 0; i--)
        {
            Debug.Log("Hola! :)" + i);

            //i--
        }

        // ejecutamos aqui, fuera del bucle
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
