using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class OldestChildVisitor : IVisitor
    {   
        public List<string> OldestChildList {get;set;}
        public int OldestChild {get; set;}

        public OldestChildVisitor()
        {
            OldestChild=0;
            OldestChildList= new List<string>();
        }
        public void Visit(Person person)
        {
            person.Accept(this);
        }
        public void Visit(Node<Person> node)
        {
            if(node.Children.Count==0)
            {
                if(node.Person.Edad>OldestChild)
                {
                    OldestChildList.Clear();
                    OldestChildList.Add(node.Person.Nombre);
                    OldestChild=node.Person.Edad;
                }
                else if (node.Person.Edad==OldestChild)
                {
                    OldestChildList.Add(node.Person.Nombre);
                }
            }
            else
            {
                foreach(Node<Person> n in node.Children)
                {
                    Visit(n);
                }
            }
        }
      
    }
}