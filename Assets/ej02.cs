﻿/*2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej02 : MonoBehaviour
{

    public float precio1;
    public float precio2;
    public float precio3;
    public float montoDisponible;
    float dineroRestante;
    float dineroFaltante;


    // Start is called before the first frame update
    void Start()
    {
        if (precio1 + precio2 + precio3 >= montoDisponible)
        {
            dineroRestante = precio1 + precio2 + precio3 - montoDisponible;
            Debug.Log("La suma de el precio de los 3 productos supera el monto disponible. Sobran $" + dineroRestante);
       
        }
        else
        {
            dineroFaltante = montoDisponible - precio1 + precio2 + precio3;
            Debug.Log("La suma de el precio de los 3 productos no supera el monto disponible. Faltan $" + dineroFaltante);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
