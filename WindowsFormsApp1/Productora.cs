using MongoDB.Bson;

namespace WindowsFormsApp1
{
    class Productora
    {
        public ObjectId id { get; set; }
        public string nombre { get; set; }
        public int año { get; set; }
        public string sitioWeb { get; set; }

        public Productora() { }

        public Productora(string nombre,int año,string sitioWeb)
        {
            this.nombre = nombre;
            this.año = año;
            this.sitioWeb = sitioWeb;
        }

        public Productora(ObjectId id,string nombre, int año, string sitioWeb)
        {
            this.id = id;
            this.nombre = nombre;
            this.año = año;
            this.sitioWeb = sitioWeb;
        }
    }
}