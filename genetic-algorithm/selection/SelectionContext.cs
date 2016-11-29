using genetic_algorithm.population;

namespace genetic_algorithm.selection
{
    class SelectionContext
    {
        ISelection strategy;

        public SelectionContext(ISelection strategy)
        {
            this.strategy = strategy;
        }

        public Population executeStrategy(Population p)
        {
            return strategy.select(p);
        }
    }
}
