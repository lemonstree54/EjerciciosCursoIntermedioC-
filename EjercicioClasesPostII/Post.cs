using System;
using System.Collections.Generic;


namespace EjercicioClasesPostII
{
    public class Post
    {

        public List<Post> post = new List<Post>();
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPost { get; set; }

        public int Voto = 0;
        public int Votar(Boolean tipoVoto)
        {
            if (tipoVoto)
                return Voto += 1;

                return Voto -= 1;
        }



    }
}
