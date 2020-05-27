using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        private T person;
        private List<Node<T>> children = new List<Node<T>>();

        public T Person {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T person)
        {
            this.person = person;
        }
             
        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this); // están ??
        }
        
    }
}
