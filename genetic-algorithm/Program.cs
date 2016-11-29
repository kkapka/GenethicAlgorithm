using genetic_algorithm.crossing;
using genetic_algorithm.mutation;
using genetic_algorithm.population;
using genetic_algorithm.selection;

namespace genetic_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectionType=args[0];
            string crossoverType=args[1];
            string mutationType=args[2];

            Population population = new Population();

            population = new SelectionContext(new SelectionFactory().getSelectionMethod(selectionType)).executeStrategy(population);
            population = new CrossoverContext(new CrossoverFactory().getCrossoverMethod(crossoverType)).executeStrategy(population);
            population = new MutationContext(new MutationFactory().getMutationMethod(mutationType)).executeStrategy(population);
        }
    }
}
