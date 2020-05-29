using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class LongestNameVisitor : IVisitor
    {   
        public string LName{get; set;}


        public LongestNameVisitor()
        {
            LName="";
        }
        
        public void Visit(Person person)
        {
            person.Accept(this);
        }

        public void Visit(Node<Person> node)
        {
            if(node.Person.Nombre.Length>this.LName.Length)
            {
                LName=node.Person.Nombre;
            }
            if (node.Children!=null)
            {
                foreach(Node<Person> n in node.Children)
                {
                    Visit(n);
                }
            }
        }
    }
}