using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEnZ.GEnZ.GenticAlgorithm
{
    public class GeneticContext
    {
        private int m_populationSize = 0;
        public int PopulationSize
        {
            get
            {
                return m_populationSize;
            }
            set
            {
                m_populationSize = value;
                GeneratePopulation();
            }
        }
        public double MutationRate { get; set; }
        public int GenomeLength { get; set; }
        public int MaxVertices { get; set; }
        public int Generations { get; set; }
        public Boolean IsPopulationInitiated = false;

        public List<Individual> Individuals { get; private set; }

        public GEnZContext Context { get; set; }

        public GeneticContext(GEnZContext context,
                                                    int populationSize,
                                                    double mutationRate,
                                                    int genomeLength,
                                                    int maxVertices,
                                                    int generations)
        {
            this.Context = context;
            this.MutationRate = mutationRate;
            this.GenomeLength = genomeLength;
            this.MaxVertices = maxVertices;
            this.Generations = generations;
            if (IsPopulationInitiated)
                this.PopulationSize = populationSize;

            this.IsPopulationInitiated = true;

            // Sort by fitness
        }
        public void GeneratePopulation()
        {
            Individuals = new List<Individual>();
            for (int i = 0; i < PopulationSize; i++)
            {
                Individuals.Add(new Individual(Context));
            }
        }
        public void SortPopulation()
        {
            Individuals.Sort((a, b) => a.Fitness.CompareTo(b.Fitness));
            Individuals.Reverse();
        }
        public void Forward()
        {
            var selectionCount = (int)(PopulationSize / 10);
            for (int i = selectionCount; i < PopulationSize; i++)
            {
                var parent1 = Individuals[GEnZContext.RandomInt(0, selectionCount)];
                var parent2 = Individuals[GEnZContext.RandomInt(0, selectionCount)];
                Individuals[i] = new Individual(Context, parent1, parent2);
            }
            SortPopulation();
            // Sort by fitness
        }
        public Individual GetFittest() => Individuals[0];
    }
}
