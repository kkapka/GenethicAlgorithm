using genetic_algorithm.population;

namespace genetic_algorithm.crossing
{
    class CrossoverContext
    {
        ICrossover strategy;

        public CrossoverContext(ICrossover strategy)
        {
            this.strategy = strategy;
        }

        public Population executeStrategy(Population p)
        {
            return strategy.cross(p);
        }
    }
}
