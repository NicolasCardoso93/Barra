using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Barras
{
    public class Barra
    {

        public int capacidad = 2;
        const int cantidadHilos = 5;
        public List<Bebida> bebida { get; set; }
        public Queue<Cliente> filaClientes { get; set; }
        public int cantidadDePersonas { get; set; }
        public int stock { get; set; }
        public int tiempoDeTarea { get; set; }
        public string nombreDeTarea { get; set; }
        private static int count = 0;

        private static Semaphore semaforo = new Semaphore(0, cantidadHilos);
        public Barra()
        {
            filaClientes = new Queue<Cliente>();
            bebida = new List<Bebida>();
        }
        private bool stockDeBebidas(Bebida bebidas) => bebidas.stock == 0;


        public void ClienteEnBarra(Cliente cliente)
        {

            semaforo.WaitOne();
            Console.WriteLine($"{cliente.nombre} ingreso al bar");
            do
            {
                if (!AlcanzaStock(cliente.BebidaDeseada))
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
        public void clientesAHilo()
        {
            var tareas = new List<Task>();
            while (filaClientes.Count != 0)
            {
                var cliente = filaClientes.Dequeue();
                tareas.Add(new Task(() => ClienteEnBarra(cliente)));
            }
            tareas.ForEach(t => t.Start());
            semaforo.Release();
            Task.WaitAll(tareas.ToArray());
        }

        public void agregarCliente(Cliente cliente)
        {
            filaClientes.Enqueue(cliente);
        }

        public bool AlcanzaStock(Bebida bebida) => bebida.stock > 0;



    }
}
