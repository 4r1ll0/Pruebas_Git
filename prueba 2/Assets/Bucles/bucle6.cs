using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int suma = 0;
        for (int i=1; i <= 100; i++);
        {
            suma = i + suma;
            Debug.Log(suma);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
