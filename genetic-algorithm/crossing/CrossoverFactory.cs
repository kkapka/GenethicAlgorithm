namespace genetic_algorithm.crossing
{
    class CrossoverFactory
    {
        public ICrossover getCrossoverMethod(string option)
        {
            if (option == "-cs")
            {
                return new SinglePointCrossover();
            }
            else if (option == "-ct")
            {
                return new TwoPointCrossover();
            }
            else
            {
                return null;
            }
        }
    }
}