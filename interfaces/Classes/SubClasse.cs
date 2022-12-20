using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interfaces.Classes
{
  public class SubClasse : ClasseBase<string>
  {
    public override string Metodo2()
    {
      throw new NotImplementedException();
    }
 
  }
}