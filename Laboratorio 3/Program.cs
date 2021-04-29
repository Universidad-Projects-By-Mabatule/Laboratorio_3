using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingFactory training = new ConcreteTrainingFactory();
            Console.WriteLine("************************************************");
            ITraining aerobic = training.GetTraining("Aerobic Exercise");
            aerobic.Workout(2);
            aerobic.Finish_Extra();
            Console.WriteLine("************************************************");
            ITraining flexibilidad = training.GetTraining("Flexibility Exercise");
            flexibilidad.Workout(2);
            flexibilidad.Finish_Extra();
            Console.WriteLine("************************************************");
            ITraining resistencia = training.GetTraining("Resistance Exercise");
            resistencia.Workout(2);
            resistencia.Finish_Extra();

        }
    }
}
