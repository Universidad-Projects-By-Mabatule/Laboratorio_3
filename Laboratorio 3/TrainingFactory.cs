using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public abstract class TrainingFactory
    {
        public abstract ITraining GetTraining(string training);
    }
}
