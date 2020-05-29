using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class FamilyAgeVisitor : IVisitor
    {
        public int FamilyAge{get;set;}

        public void Visit(Person person)
        {
            person.Accept(this);
        }

        public void Visit(Node<Person> node)
        {
            FamilyAge+=node.Person.Edad;

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