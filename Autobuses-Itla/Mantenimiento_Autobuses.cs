using System;
using System.Collections.Generic;

namespace AutobusesItla
{
    class Mantenimiento_Autobuses
    {
        public string PlateNumber { get; set; }
        public string brand { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }


        public Mantenimiento_Autobuses(string PlateNumber, string brand, string Model, int Capacity)
        {
            this.PlateNumber = PlateNumber;
            this.brand = brand;
            this.Model = Model;
            this.Capacity = Capacity;
        }
        public static List<Mantenimiento_Autobuses> _Bus = new List<Mantenimiento_Autobuses>();

        public void AddBus(Mantenimiento_Autobuses bus)
        {
            _Bus.Add(bus);
        }
        public static void Show()
        {
            if (_Bus.Count == 0)
            {
                Console.WriteLine("\t  Aun no existe ningun autobus registrado");
            }
            else
            {
                Console.Write("\n\t\t LISTADO DE AUTOBUSES \n");
                int count = 1;
                foreach (Mantenimiento_Autobuses _Autobuses in _Bus)
                {
                    {
                        Console.WriteLine("🚌 Autobus NO.: " + count + " .\n" +
                            " - Numero de Placa:" + _Autobuses.PlateNumber + " .\n" +
                            " - Marca: " + _Autobuses.brand + " .\n" +
                            " - Modelo: " + _Autobuses.Model + " .\n" +
                            " - Capacidad de pasajeros: " + _Autobuses.Capacity + " .\n");

                        count++;
                    }
                }
            }

        }
        public void Edit_Bus(Mantenimiento_Autobuses Bus_List, int index, Mantenimiento_Autobuses newBus)
        {
            Bus_List[index] = newBus;
        }

    }


}
