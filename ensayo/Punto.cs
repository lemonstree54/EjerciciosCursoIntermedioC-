using System;

namespace ensayo
{
    public class Punto
    {
        public int X;
        public int Y;

        public Punto(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }    

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Punto nuevoPunto)
        {
            if (nuevoPunto == null)
                throw new Exception(nuevoPunto.ToString());
            Move(nuevoPunto.X, nuevoPunto.Y);
        }
    }
}
