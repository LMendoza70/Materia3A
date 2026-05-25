using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materia3A.Cafeteria
{
    internal class Bebida
    {
        protected float Precio;
        protected string Nombre;
        protected string Tamaño;

        public float precio
        {
            get { return Precio; }
            set
            {
                if (value > 0)
                {
                    Precio = value;
                }
                else
                {
                    Precio = -1;
                }
            }
        }

        public string tamaño{
            get { return Tamaño; }
            set { Tamaño = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public Bebida()
        {
            Nombre = "";
            Tamaño = "";
            Precio = 0;
        }

        public Bebida(string _nombre, string _tamaño, float _precio)
        {
            this.Nombre = _nombre;
            Tamaño = _tamaño;
            Precio = _precio;
        }

        public virtual string Preparar()
        {
            return "Estamos preparando un : "+Nombre + " De tamño : "+Tamaño;
        }

        public void Descuento(float descuento)
        {
            Precio = Precio * (1 - (descuento / 100));
        }
    }
}
