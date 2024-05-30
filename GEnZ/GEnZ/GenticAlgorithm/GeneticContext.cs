using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEnZ.GEnZ.GenticAlgorithm
{
    public class GeneticContext
    {
        public int PopulationSize { get; private set; }
        public double MutationRate { get; private set; }
        public int GenomeLength { get; private set; }

        public GeneticContext(int populationSize, 
                                                    double mutationRate,
                                                    int genomeLength)
        {
            this.PopulationSize = populationSize;
            this.MutationRate = mutationRate;
            this.GenomeLength = genomeLength;
        }
    }
}
