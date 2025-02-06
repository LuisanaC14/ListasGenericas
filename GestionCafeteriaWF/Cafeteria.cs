using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCafeteriaWF
{
    public class Cafeteria 
    {
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }

        public Cafeteria(string cliente, string producto, int cantidad)
        {
            Cliente = cliente;
            Producto=producto;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"Cliente: {Cliente} - Producto: {Producto} - Cantidad: {Cantidad}";
        }
    }
}
