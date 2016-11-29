using genetic_algorithm.population;

namespace genetic_algorithm.mutation
{
    class MutationContext
    {
        IMutation strategy;

        public MutationContext(IMutation strategy)
        {
            this.strategy = strategy;
        }

        public Population executeStrategy(Population p)
        {
            return strategy.mutate(p);
        }
    }
}
