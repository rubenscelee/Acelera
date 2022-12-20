using System.Collections;
using interfaces.Classes;



Stack pilha = new Stack();

pilha.Push("1");
pilha.Push("2");
pilha.Push("3");
pilha.Push("4");

System.Console.WriteLine(pilha.Pop());
 
System.Console.WriteLine(pilha.Peek()); 


/* 
  foreach (var item in pilha)
{
  System.Console.WriteLine(item);
}
*/
 
 
