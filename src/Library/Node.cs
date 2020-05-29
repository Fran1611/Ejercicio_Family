using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T> : IElement
    {
        private Person person;
        private List<Node<T>> children = new List<Node<T>>();

        public Person Person {
            get
            {
                return this.person;
            }
            set
            {
                person = value;
            }
        }

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.Person = person;
        }
             
        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(Person);
        }
    }
}
