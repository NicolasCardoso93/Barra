using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barras
{
    public class Bebida
    {
        public string nombre { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public Bebida()
        {

        }
        public void seTomoUna()
        {
            stock--;
        }

    }
}
