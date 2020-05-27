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
            
            Node nodoFrancisco = new Node(francisco);
            Node nodoFelipe = new Node(felipe);
            Node nodoMatias = new Node(matias);
            Node nodoDiego = new Node(diego);
            Node nodoJuan = new Node(juan);
            Node nodoAna = new Node(ana);
            Node nodoPedro = new Node(pedro);
            Node nodoLuis = new Node(luis);
            Node nodoAgustin = new Node(agustin);
            Node nodoJavi = new Node(javi);
            

            
            nodoJavi.AddChildren(nodoLuis);
            
            nodoLuis.AddChildren(nodoAna);
            nodoLuis.AddChildren(nodoJuan);
            nodoLuis.AddChildren(nodoFrancisco);
            nodoLuis.AddChildren(nodoPedro);

            nodoPedro.AddChildren(nodoAgustin);
            nodoFrancisco.AddChildren(nodoFelipe);
            nodoAna.AddChildren(nodoMatias);
            nodoJuan.AddChildren(nodoDiego);
                        

            // visitar el árbol aquí
        }
    }
}
