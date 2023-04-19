namespace Overview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ByValue - ByReference primitive

            // ByValue
            int x = 12;
            Console.WriteLine($"x vor AddOne: {x}");
            AddOne(x);
            Console.WriteLine($"x nach AddOne: {x}");

            // ByRefernce:
            Console.WriteLine($"x vor AddOneReference: {x}");
            AddOneReference(ref x);
            Console.WriteLine($"x nach AddOneReference: {x}");


            Console.WriteLine("\n");

            MyVector v = new MyVector(10, 20, 30);
            Console.WriteLine($"v vor ChangeVector: {v}");
            ChangeVector(v);
            Console.WriteLine($"v nach ChangeVector: {v}");

  
            Console.WriteLine($"v vor ChangeVectorRefernce: {v}");
            ChangeVectorRefernce(ref v);
            Console.WriteLine($"v nach ChangeVectorRefernce: {v}");
        }

        static void AddOne(int x)
        {
            x++;
        }

        static void AddOneReference(ref int x)
        {
            x++;
        }

        static void ChangeVector(MyVector v)
        {
            v = new MyVector(1, 2, 1);
        }

        static void ChangeVectorRefernce(ref MyVector v)
        {
            v = new MyVector(1,1,1);
        }

    }
}