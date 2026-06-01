using Materia3A.Departamental;
using Materia3A.Materia;

namespace Materia3A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> Productos = new List<Producto>();

            Productos.Add(new Elcetronicos("00125","Pantalla 50pulgadas ",5499.99F,9));
            Productos.Add(new Elcetronicos("00885", "Celular xiaomi ", 7499.99F, 25));
            Productos.Add(new Elcetronicos("00025", "Licuadora", 499.99F, 9));
            Productos.Add(new Ropa("00128", "Playera tipo polo ", 399.99F, false));
            Productos.Add(new Ropa("00138", "Short bañador ", 799.99F, true));
            Productos.Add(new Ropa("00178", "jersey del pumas jajajaja ", 399.99F, false));

            float total = 0;
            foreach (Producto item in Productos)
            {
                Console.WriteLine(item.Evaluacion());
                if (item is Elcetronicos elect && elect.mesesuso<=12)
                {
                    total = total + item.Reembolso();
                }
                else
                {
                    Console.WriteLine("Garantia no valida... no te regreso nada ");
                }

                
                
            }
            Console.WriteLine("El total de devoluciones hoy es de : "+total);
        }
    }
}
