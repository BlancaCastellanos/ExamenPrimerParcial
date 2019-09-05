using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Pelicula
    {
        //declarar variables
        public string TituloPelicula { get; set; }

        public string Director { get; set; }

        public string Genero { get; set; }

        public string Origen { get; set; }

        public string SinopsisPelicula { get; set; }


        //ciclos
        //duracion pelicula - ciclo
        private int _duracion;
        public int Duracion
        {

            get
            {
                return _duracion;
            }

            set
            {
                if (value >= 0) //condicion
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception(" La duracion de la pelicula debe ser mayor a 0 minutos");
                }
            }
        }

    

        //año peliculas - ciclo
        private int _año;

        public int año
        {
            get
            {
                return _año;
            }

            set
            {
                if (value >= 1800 && value <= 2019) //condicion
                {
                    _año = value;
                }
                else
                {
                    throw new Exception(" Debe estar entre el rango de años 1800 a 2019");
                }
            }
        }



        //rating de la pelicula - ciclo
        private double _rating;
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value >= 0 && value <= 10) //condicion
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("El rating de la pelicula debe ser entre 0 a 10");
                }
            }
        }



        //Declaracion datos de las peliculas
        public Pelicula()
        {
            TituloPelicula = "Nombre desconocido";
            Director = "Director desconocido";
            Genero = "Sin genero";
            Origen = "Lugar de origen desconocido";
            SinopsisPelicula = "Sinopsis desconocida";
        }


        //declaracion
        public Pelicula(string titulopelicula, int aaño)
        {
            TituloPelicula = titulopelicula;
            año = aaño;
        }


        //declaracion
        public Pelicula(string titulopelicula, int aaño, string director, string genero, string origen, string sinopsispelicula, int duracion, double rating)
        {

            TituloPelicula = titulopelicula;
            año = aaño;
            Director = director;
            Genero = genero;
            Origen = origen;
            SinopsisPelicula = sinopsispelicula;
            Duracion = duracion;
            Rating = rating;

        }

    }

}
