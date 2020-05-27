using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class FamilyAge : IVisitor
    {
        private Node raiz;
        public FamilyAge(Node raiz)
        {
            this.raiz = raiz;
        }

        public Node Raiz{get;set;}

        public int TotalAge(Node Raiz)
        {
            int age;
            age = Raiz.Person.Edad;
            foreach(Node n in Raiz.Children)
            {
                age = age + n.Person.Edad;
            }

         return age; 
        }

        public void Visit(Person person)
        {
            person.Accept(this);
        }

        public void Visit(Node node)
        {
            node.Accept(this);
        }
    }
}