using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materia3A.Materia
{
    public class Materia
    {
        //ambito de variables en c# POO 
        //public ->se puede ver desde todos lados
        //private -> solo se tiene acceso desde la clase contenedora 
        //definir nuestros atributos 
        private float parcial1;
        private float parcial2;
        private float parcial3;
        public string nombreMateria;

        //definimos propiedades 
        public float Parcial1
        {
            get { return parcial1; }
            set {
                if(value>=0 && value <= 10)
                {
                    parcial1 = value;
                }
                else
                {
                    parcial1 = -1;
                }
            }
        }
        public float Parcial2
        {

            get { return parcial2; }
            set
            {
                if(value>=0 && value <= 10)
                { 
                    parcial2 = value;
                }
                else
                {
                    parcial2 = -1;
                }
            }
        }

        public float Parcial3
        {
            get { return Parcial3; }
            set { 
                if(value>=0 && value<=10)
                    parcial3 = value;
                else
                    parcial3= -1;
            }
        }

        //definimos el metodo CalcularPromedio
        public float CalcularPromedio()
        {
            float resultado = 0f;
            resultado = (parcial1 + parcial2 + parcial3) / 3;
            return resultado;
        }
    }
}
