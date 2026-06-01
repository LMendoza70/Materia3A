using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materia3A.Departamental
{
    internal class Producto
    {
        protected string Codigo;
        protected string Nombre;
        protected float Precio;

        public string codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public string nombre {  
            get { return Nombre; } 
            set { Nombre = value; } 
        }

        public float precio
        {
            get { return Precio; }
            set
            {
                if (value <= 0)
                {
                    Precio = -1;
                }
                else
                {
                    Precio = value;
                }
            }
        }

        public Producto()
        {
            Codigo = "";
            Nombre = "";
            Precio = 0;
        }

        public Producto(string _codigo, string _nombre,  float _precio)
        {
            Codigo = _codigo;
            Nombre = _nombre;
            Precio= _precio;
        }

        // Producto vaso= new Producto("0012","Vaso termico",650.99);

        public  virtual string Evaluacion()
        {
            return "Evaluando producto: "+ Nombre +" (Código: " +Codigo+ ").";
        }

        public float Reembolso()
        {
            return Precio;
        }

    }
}
