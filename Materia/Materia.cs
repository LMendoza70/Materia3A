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

        //constructor vacio
        public Materia()
        {
            parcial1 = 0;
            parcial2 = 0;
            parcial3 = 0;
            nombreMateria = "";
        }

        //constructor parametrizado
        public Materia(string nombre, float parcial1, float parcial2, float parcial3)
        {
            nombreMateria= nombre;
            this.parcial1 = parcial1;
            this.parcial2 = parcial2;
            this.parcial3= parcial3;
        }

       
        
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

        /*public string NombreMateria
        {
            get { return nombreMateria; }
            set { nombreMateria = value; }
        }*/

        //definimos el metodo CalcularPromedio
        public float CalcularPromedio()
        {
            float resultado = 0f;
            resultado = (parcial1 + parcial2 + parcial3) / 3;
            return resultado;
        }

        public string ImprimeMateria()
        {
            return "La materia : "+ nombreMateria + " Tiene las calificaciones siguietes \n" +
                "Parcial 1 : "+ parcial1+"\n" +
                "Parcial 2 : "+ parcial2+"\n" +
                "Parcial 3 : "+parcial3;
        }
    }
}
