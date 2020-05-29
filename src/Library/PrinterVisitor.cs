using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class PrinterVisitor : IVisitor
    {

        private string tabulador = "   ";

        public void Visit(Person person)
        {
            person.Accept(this);
        }

        public void Visit(Node<Person> node)
        {
            System.Console.WriteLine($"{tabulador}{node.Person.Nombre} , {node.Person.Edad} años");


            if (node.Children != null)
            {
                tabulador += "   ";
                foreach (Node<Person> n in node.Children)
                {

                    Visit(n);
                    tabulador = tabulador.Remove(tabulador.Length - 3);
                }

            }
        }
    }
}