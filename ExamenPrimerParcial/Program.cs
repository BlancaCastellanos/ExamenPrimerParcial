using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Playlists> playlists = new List<Playlists>();


            //Playlist 1
            Playlists playlists1 = new Playlists("Playlists 1");

            playlists1.Descripcion = "Esta es una Playlists muy variada";

            playlists1.Peliculas.Add(new Pelicula("Pelicula1", 1892, "Director1", "Comedia", "Estados Unidos", "Comentario 1", 88, 8.1));
            playlists1.Peliculas.Add(new Pelicula("Pelicula2", 2000, "Director2", "Ciencia Ficcion", "Mexico", "Comentario 2", 93, 9.2));
            playlists1.Peliculas.Add(new Pelicula("Pelicula3", 1900, "Director3", "Infantil", "Inglaterra", "Comentario 3", 102, 7.3));
            playlists1.Peliculas.Add(new Pelicula("Pelicula4", 1950, "Director4", "Terror", "Mexico", "Comentario 4", 93, 3.2));
            playlists1.Peliculas.Add(new Pelicula("Pelicula5", 1969, "Director5", "Ciencia Ficcion", "España", "Comentario 5", 115, 1.1));
            playlists1.Peliculas.Add(new Pelicula("Pelicula6", 1899, "Director6", "Terror", "Estados Unidos", "Comentario 6", 121, 8.6));
            playlists1.Peliculas.Add(new Pelicula("Pelicula7", 1965, "Director7", "Comedia", "Polonia", "Comentario 7", 99, 8.9));



            //Playlist 2
            Playlists playlists2= new Playlists("Playlists 2");

            playlists2.Descripcion = "Esta es una Playlist de distintas peliculas de Ciencia Ficcion";

            playlists2.Peliculas.Add(new Pelicula("Pelicula8", 1845, "Director8", "Ciencia Ficcion", "Estados Unidos", "Comentario 8", 111, 7.1));
            playlists2.Peliculas.Add(new Pelicula("Pelicula9", 2019, "Director9", "Ciencia Ficcion", "Estados Unidos", "Comentario 9",109, 9.1));
            playlists2.Peliculas.Add(new Pelicula("Pelicula10", 1925, "Director10", "Ciencia Ficcion", "Inglaterra", "Comentario 10", 95, 6.6));
            playlists2.Peliculas.Add(new Pelicula("Pelicula11", 1892, "Director11", "Ciencia Ficcion", "Inglaterra", "Comentario 11", 99, 7.8));
            playlists2.Peliculas.Add(new Pelicula("Pelicula12", 1923, "Director12", "Ciencia Ficcion", "Estados Unidos", "Comentario 12", 123, 6.2));
            playlists2.Peliculas.Add(new Pelicula("Pelicula13", 1888, "Director13", "Ciencia Ficcion", "Estados Unidos", "Comentario 13", 94, 6.3));
            playlists2.Peliculas.Add(new Pelicula("Pelicula14", 1965, "Director14", "Ciencia Ficcion", "Inglaterra", "Comentario 14", 115, 4.2));


            playlists.Add(playlists1);
            playlists.Add(playlists2);


            //ciclo de impresion
            foreach (Playlists playlist in playlists)
            {
                Console.WriteLine("\n Titulo : " + playlist.TituloPlaylists + "\n Descripción:  " + playlist.Descripcion);


                Console.WriteLine("\n Lista peliculas:\n ");
                foreach (Pelicula pelicula in playlist.Peliculas)
                {
                    Console.WriteLine("-" + pelicula.TituloPelicula + " " + pelicula.año);
                }

            }
            Console.Read();
        }
    }
}
