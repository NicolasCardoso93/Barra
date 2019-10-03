using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    public class Cliente
    {
        public string nombre { get; set; }
        public float plata { get; set; }
        public float tiempoConsumo { get; set;}
        public Queue<Bebida> bebidasDeseadas { get; set; }

        public Cliente()
        {

        }
        public void agregarBebidas(Bebida bebidas)
        {
            bebidasDeseadas.Enqueue(bebidas);
        }

        private bool teAlcanza(Bebida bebidas)
        {
            if (bebidas.precio < plata)
            {
                return false;
            }
            return true;
        }

        private bool stockDeBebidas(Bebida bebidas) => bebidas.stock == 0;

        public void comprarBebida(Bebida bebidas)
        {
            stockDeBebidas(bebidas);
            teAlcanza(bebidas);
            bebidasDeseadas.Dequeue();
            comprar(bebidas);
        }
        private void comprar(Bebida bebidas)
        {
            plata -= bebidas.precio;
            bebidas.stock -= 1;
        }
        private Bebida BebidaDeseada => bebidasDeseadas.Peek();        
            
    }
}
