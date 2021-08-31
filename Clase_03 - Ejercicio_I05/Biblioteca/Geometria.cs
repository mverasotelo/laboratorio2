using System;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
    }

    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            //this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice3 = vertice3;
            //this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }

        public string GetVertice1()
        {
            return $"{vertice1.GetX()}, {vertice1.GetY()}";
        }

        public string GetVertice2()
        {
            return $"{vertice2.GetX()}, {vertice2.GetY()}";
        }

        public string GetVertice3()
        {
            return $"{vertice3.GetX()}, {vertice3.GetY()}";
        }

        public string GetVertice4()
        {
            return $"{vertice4.GetX()}, {vertice4.GetY()}";
        }

        public float Area()
        {
            return 0;
        }

        public float Perimetro()
        {
            return 0;
        }
    }
}
