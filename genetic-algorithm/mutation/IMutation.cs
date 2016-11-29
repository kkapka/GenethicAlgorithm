using genetic_algorithm.population;

namespace genetic_algorithm.mutation
{
    interface IMutation
    {
        Population mutate(Population p);
    }
}
