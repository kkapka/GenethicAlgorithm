using genetic_algorithm.population;

namespace genetic_algorithm.selection
{
    interface ISelection
    {
        Population select(Population p);
    }
}
