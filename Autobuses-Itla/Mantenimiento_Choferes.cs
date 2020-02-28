using System;
using System.Collections.Generic;

namespace AutobusesItla
{
    public class Mantenimiento_Choferes
    {
        private static List<Choferes> _Choferes = new List<Choferes>();

        private struct Choferes
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public List<string> AssignedBuses { get; set; }

        }
        public Mantenimiento_Choferes()
        {
        }

        public void MenuPrincipal()
        {
            Console.Clear();
            Console.Title = "Mantenimiento de Choferes";
            Console.WriteLine("\t 1. Ingresar Choferes ");
            Console.WriteLine("\t 2. Editar Choferes ");
            Console.WriteLine("\t 3. Eliminar Choferes ");
            Console.WriteLine("\t 4. Listar Choferes ");
            Console.WriteLine("\t 5. Volver atrás");

            Console.Write("\t Ingrese el número segun la opción deseada: ");
            int Menu = Convert.ToInt32(Console.ReadLine());

            switch (Menu)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 0:
                    Console.ReadKey();
                    break;
            }
        }
        private static void Add<T>(List<T> _List, T Element)
        {
            _List.Add(Element);
        }
        private static void Edit<T>(List<T> _List, int index, T Element)
        {
            _List[index] = Element;
        }
        private static void Delete<T>(List<T> _List, int index)
        {
            _List.RemoveAt(index);
        }

        private static void FormAddChoferes()
        {
            Console.Write("\t Nombre: ");
            string name = Console.ReadLine();
            Console.Write("\t Apellido: ");
            string lastName = Console.ReadLine();
            Console.Write("\t Numero telefónico: ");
            string phoneNumber = Console.ReadLine();

            Choferes Choferes = new Choferes();

            Choferes.Name = name;
            Choferes.LastName = lastName;
            Choferes.PhoneNumber = phoneNumber;


            Add(_Choferes, Choferes);

            if (_Choferes.Count != 0)
            {
                Console.WriteLine("Choferes Guardado Con Exito!!");
            }
            else
            {
                Console.WriteLine(" :( Choferes no guardado, verifique e intente nuevamente.");
            }

        }
    }
}
