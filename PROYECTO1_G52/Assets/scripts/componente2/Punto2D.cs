using UnityEngine;
using System;

namespace packagePunto2D
{
    [Serializable]
 public class Punto
 {
       private float x;
       private float y;

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