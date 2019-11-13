using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bar
{
    public class Barra
    {
     
        public int capacidad { get; set; }
        const int cantidadHilos = 5;
        public List<Bebida> bebidas { get; set; }
        public Queue<Cliente> filaClientes { get; set; }
        public int cantidadDePersonas { get; set; }
        public int stock { get; set; }
        public int tiempoDeTarea { get; set; }
        public string nombreDeTarea { get; set; }
       
        private static Semaphore semaforo = new Semaphore(0, cantidadHilos);
        public Barra()
        {

        }
        private bool stockDeBebidas(Bebida bebidas) => bebidas.stock == 0;


        public void ClienteEnBarra(Cliente cliente)
        {

            semaforo.WaitOne();
            Console.WriteLine($"{cliente.nombre} ingreso al bar");
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
                Thread.Sleep(cliente.tiempoConsumo);
      

            } while (cliente.quiereSeguirTomando);
            Console.WriteLine("Y Se marchooo");
            semaforo.Release();
        }
        public bool alcanzaStock(Bebida bebida) => bebida.stock > 0;
       
       




   }
}
