using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class LongestNameVisitor : IVisitor
    {   

        public List<String> names = new List<string>();
        public string LName{get;set;}
        public void Visit(Person person)
        {
            person.Accept(this);
        }

        public void Visit(Node<Person> node)
        {
            /*bool i =  true;
            Node<Person> node1 = node;
            names.Add(node1.Person.Nombre);
            while(i)
            {   
                if (node1.Children.Count != 0)
                {
                    foreach(Node<Person> n in node1.Children)
                    {
                        names.Add(n.Person.Nombre);
                        if(n.Children.Count == 0)
                        {
                            i = false;    
                        }
                        else
                        {
                            node1 = n;
                        }
                    }
                }
            }*/
        }

        /*
        public void Visit(Node<Person> node)
        {
            names.Add(node.Person.Nombre);
            if (node.Children!=null)
            {
                foreach(Node<Person> n in node.Children)
                {
                    Visit(n);
                }
            }
        }*/
    }
}