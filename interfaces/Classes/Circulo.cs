using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interfaces.Classes
{
    public class Circulo : IFigura
    {
        public double Raio { get; set; }
        
        public double calcularArea() 
        {
            return Math.PI * Math.Pow(this.Raio, 2);
        }

        public string resultado()
        {
        throw new NotImplementedException();
        }
  }
}