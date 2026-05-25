using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materia3A.Cafeteria
{
    internal class BebidaCaliente:Bebida
    {
        private float Temperatura;

        public float temperatura
        {
            get {  return Temperatura; }
            set { Temperatura = value; }
        }

        public BebidaCaliente(string _nombre,string _tamaño, float _temperatura, float _precio):base(_nombre,_tamaño,_precio)
        {
            Temperatura = _temperatura;
        }

        public override string Preparar()
        {
            return "Estamos preparando un : "+Nombre+" Caliente  a una temperatura de : "+Temperatura + " tamaño : "+Tamaño;
        }
    }
}
