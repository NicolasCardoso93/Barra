using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    public class Cliente
    {
        public string nombre { get; set; }
        public float plata { get; set; }
        public int tiempoConsumo { get; set;}
        public Queue<Bebida> bebidasDeseadas { get; set; }

        public Cliente()
        {

        }
        public void agregarBebidas(Bebida bebidas)
        {
            bebidasDeseadas.Enqueue(bebidas);
        }

        public bool TeAlcanza => BebidaDeseada.precio <= plata;  


        public void comprarBebida()
        {
            comprar();
            bebidasDeseadas.Dequeue();            
        }
        private void comprar()
        {
            plata -= BebidaDeseada.precio;
            BebidaDeseada.stock--;
        }
        public Bebida BebidaDeseada => bebidasDeseadas.Peek();

        public bool quiereSeguirTomando => bebidasDeseadas.Count != 0;            
    }
}
