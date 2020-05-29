using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class OldestChildVisitor : IVisitor
    {   
        List<int> oldestChildList =  new List<int>();
        private int oldestChild = 0;
        public int OldestChild {get; set;}
        private Node<Person> raiz;
        public OldestChildVisitor(Node<Person> raiz)
        {
            this.raiz = raiz;
        }
        public void Visit(Person person)
        {
            person.Accept(this);
        }

        public void Visit(Node<Person> node)
        {
            foreach(Node<Person> n in node.Children)
            {
                oldestChildList.Add(n.Person.Edad);
            }
            foreach(int i in oldestChildList)
            {
                if (i > oldestChild)
                {
                    oldestChild = i;
                }
            }
        }
    }
}