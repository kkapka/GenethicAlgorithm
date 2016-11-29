using genetic_algorithm.population;

namespace genetic_algorithm.crossing
{
    interface ICrossover
    {
        Population cross(Population p);
    }
}
