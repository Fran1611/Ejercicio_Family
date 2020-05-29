using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person francisco = new Person("Francisco",26);
            Person felipe = new Person("Felipe",1);
            Person matias = new Person("Matias",7);
            Person diego = new Person("Diego",4);
            Person juan = new Person("Juan",22);
            Person ana = new Person("Ana",25);
            Person pedro = new Person("Pedro",33);
            Person luis = new Person("Luis",44);
            Person agustin = new Person("Agustin",15);
            Person javi = new Person ("Javi",70);
            
            Node<Person> nodoFrancisco = new Node<Person>(francisco);
            Node<Person> nodoFelipe = new Node<Person>(felipe);
            Node<Person> nodoMatias = new Node<Person>(matias);
            Node<Person> nodoDiego = new Node<Person>(diego);
            Node<Person> nodoJuan = new Node<Person>(juan);
            Node<Person> nodoAna = new Node<Person>(ana);
            Node<Person> nodoPedro = new Node<Person>(pedro);
            Node<Person> nodoLuis = new Node<Person>(luis);
            Node<Person> nodoAgustin = new Node<Person>(agustin);
            Node<Person> nodoJavi = new Node<Person>(javi);
            

            
            nodoJavi.AddChildren(nodoLuis);
            
            nodoLuis.AddChildren(nodoAna);
            nodoLuis.AddChildren(nodoJuan);
            nodoLuis.AddChildren(nodoFrancisco);
            nodoLuis.AddChildren(nodoPedro);

            nodoPedro.AddChildren(nodoAgustin);
            nodoFrancisco.AddChildren(nodoFelipe);
            nodoAna.AddChildren(nodoMatias);
            nodoJuan.AddChildren(nodoDiego);

            FamilyAgeVisitor familyAge = new FamilyAgeVisitor();
            familyAge.Visit(nodoJavi);
            Console.WriteLine(familyAge.FamilyAge);
                  
            //LongestNameVisitor longestName = new LongestNameVisitor();
            //longestName.Visit(nodoJavi);
            //Console.WriteLine(longestName.names);

            // visitar el árbol aquí
  
            
        }
    }
}
