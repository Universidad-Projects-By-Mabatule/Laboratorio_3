using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Resistance:ITraining
    {
        public void Workout(int hrs)
        {
            switch (hrs)
            {
                case 1:
                    Console.WriteLine("La Rutina de ejercicio de Resistencia es:");
                    Console.WriteLine("Tienes que hacer " + hrs.ToString() + "horas de ejercicio");
                    Console.WriteLine("El trabajo es AMRAP que significa tantas repeticiones como sea posible");
                    Console.WriteLine("- 20 Burpees");
                    Console.WriteLine("- 20 Sumo squats(con peso)");
                    Console.WriteLine("- 20 fondos triceps");
                    Console.WriteLine("- 20 V-ups");
                    Console.WriteLine("Mucha suerte y procura tomar agua :D");
                    break;
                case 2:
                    Console.WriteLine("La Rutina de ejercicio de Resistencia es:");
                    Console.WriteLine("Tienes que hacer una runita de" + hrs.ToString() + "hora");
                    Console.WriteLine("***    1er Primer round  ***");
                    Console.WriteLine("El trabajo es AMRAP que significa tantas repeticiones como sea posible");
                    Console.WriteLine("- 60  Montain climbres");
                    Console.WriteLine("- 20  Squats");
                    Console.WriteLine("- 40  Jumping jacks");
                    Console.WriteLine("- 120 Salto de cuerda");
                    Console.WriteLine("- 12  Abdominales cortos");
                    Console.WriteLine("***    2do Primer round  ***");
                    Console.WriteLine("El trabajo es EMON que significa (very minute on a minute) ");
                    Console.WriteLine("- 15 Push ups");
                    Console.WriteLine("- 20 Squats");
                    Console.WriteLine("- 20 Jumping Lunges");
                    Console.WriteLine("- 15 V-ups");
                    Console.WriteLine("- 15 Burpees");
                    Console.WriteLine("Mucha suerte y procura tomar agua :D");
                    break;
                default:
                    throw new Exception(string.Format("2 o 1 hora de ejercicio al dia es un buen trabajo no exageres!", hrs));
            }
        }
        public void Finish_Extra()
        {
            Console.WriteLine("Tabata de 3 minutos intercalando Plancha y V-ups");
        }
    }
}
