using System;

namespace ProyectoBrain
{
    class Ranking
    //internal class Ranking // internal keyword is an access modifier for types and type members which limits access exclusively to classes defined within the current project assembly
    {
        private string nombre;
        private int puntos;
        private DateTime fecha;

        /*
            Generar automáticamente Constructor, Getters y Setters:

                - seleccionar todos los atributos con el ratón
                - hacer clic con el botón derecho
                - elegir 'Acciones rápidas y refactorizaciones...'
                - seleccionar opción deseada
        */

        public Ranking(string nombre, int puntos, DateTime fecha)
        {
            this.nombre = nombre;
            this.puntos = puntos;
            this.fecha = fecha;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Puntos
        {
            get
            {
                return puntos;
            }

            set
            {
                puntos = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

    }
}