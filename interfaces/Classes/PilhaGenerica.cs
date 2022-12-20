using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interfaces.Classes
{
    public class PilhaGenerica<T>
    {
        private List<T> elementos = new List<T>();

        

        public T Top
        {
            get => elementos[elementos.Count - 1];
        }

        public void Push(T item)
        {
            elementos.Add(item);
        }

        public T Pop(){
            T aux = default(T);

            if(elementos.Count == 0){
                return aux;
            }

            aux = Top;
            elementos.RemoveAt(elementos.Count - 1);
            
            return aux;
        }
    }
}