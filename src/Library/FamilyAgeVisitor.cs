using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class FamilyAgeVisitor : IVisitor
    {
        //private int familyAge;
        public int FamilyAge{get;set;}
        private Node<Person> raiz;
        public FamilyAgeVisitor()
        {
        }

        public Node<Person> Raiz{get;set;}


        public void Visit(Person person)
        {
            person.Accept(this);
        }

        public void Visit(Node<Person> node)
        {
            bool i =  true;
            Node<Person> node1 = node;
            FamilyAge += node1.Person.Edad;

            while(i == true)
            {
                Console.WriteLine("Hola");
                if (node1.Children.Count != 0)
                {
                    foreach(Node<Person> n in node1.Children)
                    {
                        FamilyAge += n.Person.Edad;
                        
                        // si n.Children tiene al menos 1 hijo y n es el último de los hijos, se itera al siguiente n
                        if (n.Children.Count != 0)
                        {
                            Console.WriteLine("chau");
                            node1 = n;
                        }else i = false;
                    }
                }
                else
                {
                    i = false;
                }
            }
        }
    }
}