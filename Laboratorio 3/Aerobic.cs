using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Aerobic:ITraining
    {
        public void Workout(int hrs) {
            switch (hrs)
            {
                case 1:
                    Console.WriteLine("La Rutina de Aerobic es:");
                    Console.WriteLine("Tienes que hacer " + hrs.ToString() + "hora de:");
                    Console.WriteLine("3 repeticiones de esta serie durante 20 minuntos ");
                    Console.WriteLine("- 10 Patadas de burro");
                    Console.WriteLine("- 15 Puentes");
                    Console.WriteLine("- 10 Fire hydrant");
                    Console.WriteLine("- 12 Zancadas");
                    Console.WriteLine("- 12 Mountain climbers");
                    Console.WriteLine("Mucha suerte y procura tomar agua :D");
                    break;
                case 2:
                    Console.WriteLine("La Rutina de Aerobic es:");
                    Console.WriteLine("Tienes que hacer una runita de" + hrs.ToString() + "hora");
                    Console.WriteLine("***    1er Primer round  ***");
                    Console.WriteLine("2 repeticiones de esta serie durante 20 minuntos ");
                    Console.WriteLine("- 30 Montain climbres");
                    Console.WriteLine("- 20 Squats");
                    Console.WriteLine("- 40 Jumping jacks");
                    Console.WriteLine("- 120 Salto de cuerda");
                    Console.WriteLine("- 12 abdominales cortos");
                    Console.WriteLine("***    2do Primer round  ***");
                    Console.WriteLine("- 20 jumping jacks");
                    Console.WriteLine("- 10 sido to disde lunges");
                    Console.WriteLine("- 10 sumo squats");
                    Console.WriteLine("- 10 raised arm circles");
                    Console.WriteLine("- 10 twists sumo squats");
                    Console.WriteLine("Mucha suerte y procura tomar agua :D");
                    break;
                default:
                    throw new Exception(string.Format("2 o 1 hora de ejercicio al dia es un buen trabajo no exageres!", hrs));
            }
        }
        public void Finish_Extra() {
            Console.WriteLine("Finisher >:v");
            Console.WriteLine("5 minutos de Salto de cuerda");
        }

    }
}
