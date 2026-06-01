using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materia3A.Departamental
{
    internal class Elcetronicos:Producto
    {
        private int MesesUso;

        public int mesesuso {  
            get { return MesesUso; } 
            set {
                if (value <= 0)
                {
                    MesesUso = 1;
                }
                else
                {
                    MesesUso = value;
                }
            } 
        }

        public Elcetronicos():base()
        {
            MesesUso=1;
        }

        public Elcetronicos(string _codigo, string _nombre, float _precio, int _mesesdeuso) : base(_codigo, _nombre, _precio)
        {
            MesesUso = _mesesdeuso;
        }

        public override string Evaluacion()
        {
            return "Dispositivo Electrónico: " + Nombre + ". Tiempo de uso previo: "+ MesesUso +" meses.";
        }
    }
}
