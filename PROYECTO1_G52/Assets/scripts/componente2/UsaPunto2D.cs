using UnityEngine;
using System;
using packagePunto2D;
using System.Collections.Generic;

public class UsaPunto2D : MonoBehaviour
{
    List<Punto> puntos = new List<Punto>();

    void Start()
    {
        Punto punto1 = new Punto(2, 3);
        Punto punto2 = new Punto(5, 7);


        puntos.Add(punto1);
        puntos.Add(punto2);

        for (int i = 0; i < puntos.Count; i++)
        {
            Debug.Log("Punto " + (i + 1) + ": (" + puntos[i].X + ", " + puntos[i].Y + ")");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
