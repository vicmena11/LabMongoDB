﻿using MongoDB.Bson;

namespace WindowsFormsApp1
{
    class Pelicula
    {
        public ObjectId id { get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public string director { get; set; }
        public string franquicia { get; set; }
        public string pais { get; set; }
        public int annio { get; set; }
        public int duracion { get; set; }
        public string productora { get; set; }
        public string[] actores { get; set; }
        
        

        public Pelicula()
        {

        }

        public Pelicula(string nombre, string genero, string director, string franquicia, string pais, int annio, int duracion, string productora, string[] actores)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.director = director;
            this.franquicia = franquicia;
            this.pais = pais;
            this.annio = annio;
            this.duracion = duracion;
            this.productora = productora;
            this.actores = actores;
            
        }

        public Pelicula(ObjectId id,string nombre, string genero, string director, string franquicia, string pais, int annio, int duracion,string productora, string[] actores)
        {
            this.id = id;
            this.nombre = nombre;
            this.genero = genero;
            this.director = director;
            this.franquicia = franquicia;
            this.pais = pais;
            this.annio = annio;
            this.duracion = duracion;
            this.productora = productora;
            this.actores = actores;   
        }
    }
}