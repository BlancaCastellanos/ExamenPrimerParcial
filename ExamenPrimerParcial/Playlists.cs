using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Playlists
    {
        //Declaracion de variables
            public string TituloPlaylists { get; set; }

            public string Descripcion { get; set; }

            public List<Pelicula> Peliculas { get; set; }


        //Playlists
            public Playlists()
            {
                TituloPlaylists = "La playlists no tiene nombre";
                Descripcion = "Descripción no encontrada";
                Peliculas = new List<Pelicula>();
            }



            public Playlists(string tituloplaylists)
            {
                TituloPlaylists = tituloplaylists;
                Descripcion = "Descripción no encontrada";
                Peliculas = new List<Pelicula>();
            }



            public Playlists(string tituloplaylists, string descripcion )
            {
                TituloPlaylists = tituloplaylists;
                Descripcion = "Descripción no encontrada";
                Peliculas = new List<Pelicula>();
             }
    }
}




