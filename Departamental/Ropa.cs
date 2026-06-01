using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materia3A.Departamental
{
    internal class Ropa:Producto
    {
        private bool Etiquetas;

        public bool etiquetas
        {
            get { return Etiquetas; }
            set { Etiquetas = value; }
        }

        public Ropa() : base()
        {
            Etiquetas=true;
        }

        public Ropa(string _codigo, string _nombre, float _precio, bool _etiquetas) : base(_codigo, _nombre, _precio)
        {
            Etiquetas = _etiquetas;
        }

        public override string Evaluacion()
        {
            return "Prenda de Vestir: "+Nombre+". ¿Conserva etiquetas originales?: "+Etiquetas;
        }
    }
}
