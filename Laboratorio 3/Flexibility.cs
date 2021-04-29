using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Flexibility:ITraining
    {
        public void Workout(int hrs)
        {
            switch (hrs)
            {
                case 1:
                    Console.WriteLine("La Rutina de Flexibilidad es:");
                    Console.WriteLine("Tienes que hacer " + hrs.ToString() + "hora de:");
                    Console.WriteLine("3 repeticiones de esta serie durante 20 minuntos ");
                    Console.WriteLine("Cada ejercicio tiene una duracion de 5 minutos respiere e inhale profundo");
                    Console.WriteLine("- Espalda y pectora");
                    Console.WriteLine("- Cadera interior");
                    Console.WriteLine("- Psoas");
                    Console.WriteLine("- Femoral");
                    Console.WriteLine("- Gluteos");
                    Console.WriteLine("Mucha suerte y procura tomar agua :D");
                    break;
                case 2:
                    Console.WriteLine("La Rutina de Aerobic es:");
                    Console.WriteLine("Tienes que hacer una runita de" + hrs.ToString() + "hora");
                    Console.WriteLine("***    1er Primer round  ***");
                    Console.WriteLine("Cada ejercicio tiene una duracion de 4 minutos respiere e inhale profundo");
                    Console.WriteLine("- Espalda y pectora");
                    Console.WriteLine("- Cadera interior");
                    Console.WriteLine("- Psoas");
                    Console.WriteLine("- Femoral");
                    Console.WriteLine("- Gluteos");
                    Console.WriteLine("***    2do Primer round  ***");
                    Console.WriteLine("Cada ejercicio tiene una duracion de 4 minutos respiere e inhale profundo");
                    Console.WriteLine("- Cuadriceps");
                    Console.WriteLine("- Pectoral y hombros");
                    Console.WriteLine("- Cadena posterior");
                    Console.WriteLine("- Glúteos");
                    Console.WriteLine("- Piernas");
                    Console.WriteLine("Mucha suerte y procura tomar agua :D");
                    Console.WriteLine("Cualquier duda sobre los ejercicios puedes ver la imagenes aqui: https://guiasaludyvida.com/ejercicios-para-ganar-flexibilidad/ ");
                    break;
                default:
                    throw new Exception(string.Format("2 o 1 hora de ejercicio al dia es un buen trabajo no exageres!", hrs));
            }
        }
        public void Finish_Extra()
        {
            Console.WriteLine("Finisher >:v");
            Console.WriteLine("30 Burpees");
        }
    }
}
