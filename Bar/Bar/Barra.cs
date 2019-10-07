using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    public class Barra
    {
        public int capacidad { get; set; }
        public List<Bebida> bebidas { get; set; }
        public Queue<Cliente>clientes { get; set; }
        public Queue<Cliente> colaDeEspera { get; set; }
        public Barra()
        {

        }

        public void barraLlena(Cliente clientes)
        {

        }
    }
}
