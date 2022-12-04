namespace Room1SortProjectApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting App, using GitHub\n" +
                "Collaborators: \nmdahirr\nMissMatilde\nSAlighan07\nDavid-Sparta\n");

            var sort = SortController.GetSort("BubbleSort");
            Console.WriteLine(sort.MakeSorted());

            sort = SortController.GetSort("MergeSort");
            Console.WriteLine(sort.MakeSorted());

            sort = SortController.GetSort("Library");
            Console.WriteLine(sort.MakeSorted());

            try
            {
                sort = SortController.GetSort("No Method Chosen");
                Console.WriteLine(sort.MakeSorted());
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

    }// end of class
}// end of namespace