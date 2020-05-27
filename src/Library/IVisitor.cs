using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IVisitor
    {
        void Visit(Person person);
        void Visit(Node<Person> node);
    }
}