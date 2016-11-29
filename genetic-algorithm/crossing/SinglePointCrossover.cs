using genetic_algorithm.population;
using System;

namespace genetic_algorithm.crossing
{
    class SinglePointCrossover:ICrossover
    {
        public Population cross(Population p)
        {
            Console.WriteLine("Single Point Crossover");
            return null;
        }
    }
}
