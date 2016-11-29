namespace genetic_algorithm.mutation
{
    class MutationFactory
    {
        public IMutation getMutationMethod(string option)
        {
            if (option == "-mb")
            {
                return new BitStringMutation();
            }
            else if (option == "-mf")
            {
                return new FlipBitMutation();
            }
            else
            {
                return null;
            }
        }
    }
}
