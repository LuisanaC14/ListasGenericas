using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCafeteriaWF
{
    public class ListaPedidos
    {
        private List<Cafeteria> pedidos;

        public ListaPedidos()
        {
            pedidos = new List<Cafeteria>();
        }

        public void AgregarPedido(Cafeteria pedido)// MODIFICADO
        {
            pedidos.Add(pedido);
        }

        public Cafeteria ProcesarPedido()// Linea 23 agrega !!
        {
            if (pedidos.Count > 0)
            {
                Cafeteria procesado = pedidos[0];
                pedidos.RemoveAt(0);
                return procesado;
            }
            else
            {
                return null;
            }
        }

        public List<Cafeteria> ObtenerPedidos()
        {
            return new List<Cafeteria>(pedidos);
        }
    }
}

