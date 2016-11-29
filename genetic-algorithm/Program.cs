using genetic_algorithm.crossing;
using genetic_algorithm.mutation;
using genetic_algorithm.population;
using genetic_algorithm.selection;
using System;

namespace genetic_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // przerobić to na program odpalany z cmd (pobiera wartości z args) i zaimplementować metody
            string selectionType=Console.ReadLine();
            string crossoverType= Console.ReadLine();
            string mutationType= Console.ReadLine();

            Population population = new Population();

            population = new SelectionContext(new SelectionFactory().getSelectionMethod(selectionType)).executeStrategy(population);
            population = new CrossoverContext(new CrossoverFactory().getCrossoverMethod(crossoverType)).executeStrategy(population);
            population = new MutationContext(new MutationFactory().getMutationMethod(mutationType)).executeStrategy(population);

            Console.ReadLine();
        }
    }
}
