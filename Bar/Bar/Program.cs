using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using System.Threading.Tasks;

namespace Bar
{
    class Program
    {

        
        const int hilosOperando = 2;
      
        private static int contador = 0;

        static void Main(string[] args)
        {
            Bebida fernet = new Bebida()
            {
                nombre = "Fernet",
                precio = 110,
                stock = 40

            };
            Bebida ron = new Bebida()
            {
                nombre = "Ron con Cola",
                precio = 100,
                stock = 50

            };
            Bebida pinta = new Bebida()
            {
                nombre = "Pinta de Cerveza artesanal",
                precio = 120,
                stock = 100

            };
            Bebida daikiri = new Bebida()
            {
                nombre = "Daikiri",
                precio = 120,
                stock = 50

            };


            Cliente beto = new Cliente()
            {
                nombre = "Beto",
                plata = 500,
                tiempoConsumo = 1500
            };
            beto.agregarBebidas(pinta);
            beto.agregarBebidas(pinta);
            beto.agregarBebidas(pinta);
            beto.agregarBebidas(pinta);
            beto.agregarBebidas(pinta);

            Cliente guido = new Cliente()
            {
                nombre = "Guido",
                plata = 800,
                tiempoConsumo = 5000
            };
            guido.agregarBebidas(daikiri);
            guido.agregarBebidas(daikiri);

            Cliente adolfo = new Cliente()
            {
                nombre = "Adolfito",
                plata = 200,
                tiempoConsumo = 3500,    
            };
            adolfo.agregarBebidas(fernet);
            adolfo.agregarBebidas(ron);
            adolfo.agregarBebidas(pinta);

            Cliente ivan = new Cliente()
            {
                nombre = "Ivan",
                plata = 500,
                tiempoConsumo = 2000
            };
            ivan.agregarBebidas(pinta);
            ivan.agregarBebidas(pinta);
            ivan.agregarBebidas(pinta);

            Cliente jessica = new Cliente()
            {
                nombre = "Jessica",
                plata = 300,
                tiempoConsumo = 4500
            };
            jessica.agregarBebidas(pinta);
            jessica.agregarBebidas(pinta);
            jessica.agregarBebidas(pinta);
            jessica.agregarBebidas(pinta);
            jessica.agregarBebidas(pinta);
            jessica.agregarBebidas(pinta);
            jessica.agregarBebidas(pinta);
            jessica.agregarBebidas(pinta);
            jessica.agregarBebidas(pinta);
            jessica.agregarBebidas(pinta);



            Barra laBarrita = new Barra()
            {
                capacidad = 2,
                cantidadDePersonas = 5,
                
            };;

            laBarrita.bebidas.Add(fernet);
            laBarrita.bebidas.Add(pinta);
            laBarrita.bebidas.Add(ron);
            laBarrita.bebidas.Add(daikiri);

            


            //Task[] tareas = new Task[cantidadHilos];
            //for( int i = 0; i < cantidadHilos; i++ )
            //{
            //    tareas[i] = new Task(() => imprimirTask());
            //    tareas[i].Start();
            //}


        }
        
    }
}
