using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person 
    {
        public Person(string nombre, int edad)
        {
            this.Edad = edad;
            this.Nombre = nombre;
        }
        private string nombre;
        private int edad;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            } 
        } 
        
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                edad = value;
            }
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}