namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputList = Angabe.GenerateList();

            List<int> convertedList = SolveExercise1(inputList);
            Console.WriteLine(SolveExercise2(convertedList));
            Console.WriteLine(SolveExercise3(convertedList));

        }

        static List<int> SolveExercise1(List<string> input)
        {
            List<int> l = new List<int>();
            for (int i = 0; i < input.Count; i++) l.Add(int.Parse(input[i]));
            

            return l;
        }

        static int SolveExercise2(List<int> input)
        {
            int count = 0;
            for (int i = 0; i < input.Count - 1; i++) if (input[i] < input[i + 1]) count++;

            return count;
        }


        static int SolveExercise3(List<int> input)
        {
            int count = 0;

            int previous = input[0] + input[1] + input[2];
            int current = 0;

            for (int i = 1; i < input.Count - 2; i++)
            {
                current = input[i] + input[i + 1] + input[i + 2];

                if (current > previous) count++;

                previous = current;
            }

            return count;
        }
    }
}