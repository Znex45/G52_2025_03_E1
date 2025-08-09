using UnityEngine;
using System;

namespace packagePunto2D
{
    [Serializable]
 public class Punto
 {
       [SerializeField] private float x;
       [SerializeField] private float y;

       public Punto()
       {
       }
       public Punto(float x, float y)
       {
            this.x = x;
            this.y = y;
       }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
    }
}