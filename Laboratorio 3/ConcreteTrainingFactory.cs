using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class ConcreteTrainingFactory:TrainingFactory
    {
        public override ITraining GetTraining(string training) 
        {
            switch (training)
            {
                case "Aerobic Exercise":
                    return new Aerobic();
                case "Flexibility Exercise":
                    return new Flexibility();
                case "Resistance Exercise":
                    return new Resistance();
                default:
                    throw new Exception(string.Format("Training '{0}' cannot be created", training));
            }
        }
    }
}
