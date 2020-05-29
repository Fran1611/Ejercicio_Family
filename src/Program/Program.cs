using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Person francisco = new Person("Francisco", 26);
            Person felipe = new Person("Felipe", 1);
            Person matias = new Person("Matias", 7);
            Person diego = new Person("Diego", 4);
            Person juan = new Person("Juan", 22);
            Person ana = new Person("Ana", 25);
            Person pedro = new Person("Pedro", 33);
            Person luis = new Person("Luis", 44);
            Person agustin = new Person("Agustin", 15);
            Person javi = new Person("Javi", 70);
            Person cecilia = new Person ("Cecilia",15);

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
            Node<Person> nodoCecilia = new Node<Person>(cecilia);

            nodoJavi.AddChildren(nodoLuis);

            nodoLuis.AddChildren(nodoAna);
            nodoLuis.AddChildren(nodoJuan);
            nodoLuis.AddChildren(nodoFrancisco);
            nodoLuis.AddChildren(nodoPedro);

            nodoPedro.AddChildren(nodoAgustin);

            nodoFrancisco.AddChildren(nodoFelipe);
            nodoFrancisco.AddChildren(nodoCecilia);

            nodoAna.AddChildren(nodoMatias);

            nodoJuan.AddChildren(nodoDiego);


            //Mostrar en pantalla
            System.Console.WriteLine("\n\n\n");
            System.Console.WriteLine("**************************************************************************\n                             ARBOL GENEALOGICO\n**************************************************************************");

            PrinterVisitor pv = new PrinterVisitor();
            pv.Visit(nodoJavi);

            System.Console.WriteLine("\n**************************************************************************");

            FamilyAgeVisitor familyAge = new FamilyAgeVisitor();
            familyAge.Visit(nodoJavi);
            Console.WriteLine($"La suma de todas las edades es de {familyAge.FamilyAge} años");

            LongestNameVisitor longestName = new LongestNameVisitor();
            longestName.Visit(nodoJavi);
            Console.WriteLine($"El nombre más largo es \"{longestName.LName}\" con {longestName.LName.Length} letras");

            OldestChildVisitor oldestChild = new OldestChildVisitor();
            oldestChild.Visit(nodoJavi);

            if (oldestChild.OldestChildList.Count == 1)
            {
                System.Console.WriteLine($"El hijo más grande es \"{oldestChild.OldestChildList.ToArray()[0]}\" y tiene {oldestChild.OldestChild} años");
            }
            else
            {
                System.Console.Write($"Los hijos más grandes son: ");
                foreach (string s in oldestChild.OldestChildList)
                {
                    System.Console.Write($"{s} ");
                }
                System.Console.WriteLine($"y los {oldestChild.OldestChildList.Count} tienen {oldestChild.OldestChild} años");
            }

            System.Console.WriteLine("**************************************************************************");

        }
    }
}
