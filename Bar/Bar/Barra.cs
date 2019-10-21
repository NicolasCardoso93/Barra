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
        public int stock { get; set; }
        public Barra()
        {

        }
        private bool stockDeBebidas(Bebida bebidas) => bebidas.stock == 0;

        public void barraLlena(Cliente clientes)
        {

        }

        public void ClienteEnBar(Cliente cliente)
        {

            do
            {
                if (!alcanzaStock(cliente.BebidaDeseada))
                {
                    Console.WriteLine("No posee la bebida deseada");
                    break;
                }
                if (!cliente.TeAlcanza)
                {
                    Console.WriteLine("No posee la plata necesaria");
                    break;
                }
                Console.WriteLine($"{cliente.nombre} se compro {cliente.BebidaDeseada.nombre}");
                cliente.comprarBebida();
                
            

            } while (cliente.quiereSeguirTomando);
        }
        public bool alcanzaStock(Bebida bebida) => bebida.stock > 0;
       


   }
}
