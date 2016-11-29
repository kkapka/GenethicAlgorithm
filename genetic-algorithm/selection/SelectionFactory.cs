namespace genetic_algorithm.selection
{
    class SelectionFactory
    {
        public ISelection getSelectionMethod(string option)
        {
            if (option == "-sl")
            {
                return new LinearRankSelection();
            }
            else if (option == "-sr")
            {
                return new RouletteWheelSelection();
            }
            else if (option == "-st")
            {
                return new TournamentSelection();
            }
            else
            {
                return null;
            }
        }
    }
}
