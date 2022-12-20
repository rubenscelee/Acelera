using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interfaces.Classes
{
    public class Retangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double calcularArea(){
          return this.Base * this.Altura;
        }

        public string resultado(){
          return $"O valor da base é: {Base}";
        }
    }
}