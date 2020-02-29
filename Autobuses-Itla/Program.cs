using System;
using System.Collections.Generic;

namespace AutobusesItla
{
    class MainClass
    {
        enum Menu_Principal{ }
        enum Menu_Autobuses{ }
        enum Menu_Choferes{ }
        public static void Main(string[] args)
        {
            MenuPricipal();
        }
        //______________________________________MENU______________________________________

        public static void MenuPricipal()
        {
            while(true){
                Console.Clear();
                Console.Title = "SISTEMA DE AUTOBUSES ITLA";
                Console.WriteLine("\n\t\t MENU PRINCIPAL \n");
                Console.WriteLine("\t 1. Mantenimiento de autobuses");
                Console.WriteLine("\t 2. Mantenimiento de choferes");

                Console.Write("\t Ingrese el número segun la opción deseada: ");
                int Menu = Convert.ToInt32(Console.ReadLine());

                switch (Menu)
                {
                    case 1:
                        MenuPrincipalAutobuses();
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("\n\n \t Este número de Sección no exite .");
                        Console.ReadKey();
                        MenuPricipal();
                        break;
                }
            }
        }
        public static void MenuPrincipalAutobuses()
        {
            Console.Clear();
            Console.Title = "Mantenimiento de autobuses";
            Console.WriteLine("\n\n\t ______________________Menu______________________");

            Console.WriteLine("\n\t 1. Ingresar Autobus ");
            Console.WriteLine("\t 2. Editar Autobus ");
            Console.WriteLine("\t 3. Eliminar Autobus ");
            Console.WriteLine("\t 4. Listar Autobus ");
            Console.WriteLine("\t 5. Volver atrás");

            Console.Write("\t Ingrese el número segun la opción deseada: ");
            int Menu = Convert.ToInt32(Console.ReadLine());

            switch (Menu)
            {
                case 1:
                    Ingreso_Autobuses();
                    break;
                case 2:
                   
                    break;
                case 3:
                    Eliminar_Autobuses();
                    break;
                case 4:
                    Mostreo_Autobuses();
                    break;
                case 5:
                    Console.ReadKey();
                    MenuPricipal();
                    break;
            }
        }

        //______________________________________MANTENIMIENTO DE AUTOBUSES______________________________________

        public static void Ingreso_Autobuses()
        {

            Console.Write("\t Numero de Placa: ");
            string plateNumber = Console.ReadLine();
            Console.Write("\t Marca: ");
            string brand = Console.ReadLine();
            Console.Write("\t Modelo: ");
            string model = Console.ReadLine();
            Console.Write("\t Capacidad de pasajeros: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            try
            {
                Mantenimiento_Autobuses _Autobuses = new Mantenimiento_Autobuses(plateNumber, brand, model, capacity);
                _Autobuses.AddBus(_Autobuses);
                Console.WriteLine("Autobus Guardado Con Exito!!");
                Console.ReadKey();
                MenuPrincipalAutobuses();
            }
            catch (Exception)
            {
                Console.WriteLine("/t Datos erroneos, por favor verifique e intente nuevamente /n ");
                Console.ReadKey();
                Ingreso_Autobuses();
            }
        }
        public static void Mostreo_Autobuses()
        {
            Mantenimiento_Autobuses.Show();
        }
         public static void Editar_Autobuses()
         {

             if (Mantenimiento_Autobuses._Bus.Count == 0)
             {
                 Console.WriteLine("\t Lista de autobuses vacia");
                 Console.ReadKey();
             }
             else
             {
                 Mostreo_Autobuses();
                 Console.Write("\t Seleccione el numero segun el Autobus que desee editar: ");
                 int index = Convert.ToInt32(Console.ReadLine());

                 Console.Clear();
                 Console.WriteLine("\t\t Introduzca los nuevos valores \n ");
                 Console.Write("\t Numero de Placa: ");
                 string plateNumber = Console.ReadLine();
                 Console.Write("\t Marca: ");
                 string brand = Console.ReadLine();
                 Console.Write("\t Modelo: ");
                 string model = Console.ReadLine();
                 Console.Write("\t Capacidad de pasajeros: ");
                 int capacity = Convert.ToInt32(Console.ReadLine());

                 try
                 {
                    /* Mantenimiento_Autobuses _Autobuses = new Mantenimiento_Autobuses(plateNumber, brand, model, capacity);
                     _Autobuses.Edit_Bus(Mantenimiento_Autobuses._Bus, (index - 1), _Autobuses);*/


                     Console.WriteLine("Autobus Editado Con Exito!!");
                     Console.ReadKey();
                     MenuPrincipalAutobuses();
                 }
                 catch (Exception)
                 {
                     Console.WriteLine("/t Datos erroneos, por favor verifique e intente nuevamente /n ");
                     Console.ReadKey();
                     Ingreso_Autobuses();
                 }

                 Console.WriteLine("\t Producto Editado Con Exito!!");
             }
         }
        private static void Eliminar_Autobuses()
        {
        }
    }

}
