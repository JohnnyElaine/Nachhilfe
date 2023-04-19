using Overview;

namespace TestMyVector
{
    public class TestMyVector
    {

        /**
         * 
         * A Fact is a test method that represents a single, fixed test case. It is used when the test data is known and does not vary
         *
         * Theory is a test method that represents a set of related test cases
         */

        private MyVector v1;
        private MyVector v2;
        private MyVector v3;


        public TestMyVector()
        {
            v1 = new MyVector(1, 2, 3);
            v2 = new MyVector(-10, -20, -30);
            v3 = new MyVector(0, 0, 0);
        }

        /**
         * SIMPLE FACTS
         */

        [Fact]
        public void DistanceTo1()
        {
            double expected = Math.Sqrt(1 + 2 * 2 + 3 * 3);
            Assert.Equal(expected, v1.DistanceTo(v3));
        }

        [Fact]
        public void DistanceTo2()
        {
            double expected = Math.Sqrt(11 * 11 + 22 * 22 + 33 * 33);
            Assert.Equal(expected, v1.DistanceTo(v2));
        }

        /**
         * INLINE DATA
         */

        [Theory]
        [InlineData(10,20,30,0,0,0,0)]
        [InlineData(10, 20, 30, -2, -20, -40, -60)]
        public void MultiplicationScalar(double x, double y, double z, double scalar, double xExpected, double yExpected, double zExpected)
        {
            MyVector a = new MyVector(x, y, z);
            MyVector b = new MyVector(xExpected, yExpected, zExpected);
            Assert.Equal(a * scalar, b);
        }

        /**
         * MEMBER DATA
         */

        public static IEnumerable<object[]> DataAddition()
        {
            // yield liefert einen wert zurück. Methode speichert sich die aktuelle position und macht beim nächsten aufruf dort weiter.
            yield return new object[] {new MyVector(-1,-2,-3), new MyVector(1,2,3), new MyVector(0,0,0)};
            yield return new object[] {new MyVector(0,0,0), new MyVector(0,0,0), new MyVector(0, 0, 0) };
        }

        [Theory]
        [MemberData(nameof(DataAddition))]
        public void Addition(MyVector a, MyVector b, MyVector expected)
        {
            Assert.Equal(a + b, expected);
        }

        public static IEnumerable<object[]> DataLength()
        {
            // yield liefert einen wert zurück. Methode speichert sich die aktuelle position und macht beim nächsten aufruf dort weiter.
            yield return new object[] { new MyVector(-1, -2, 3), Math.Sqrt(1 * 1 + 2 * 2 + 3 * 3)};
            yield return new object[] { new MyVector(99, 199, 299), Math.Sqrt(99 * 99 + 199 * 199 + 299 * 299) };
        }

        [Theory]
        [MemberData(nameof(DataLength))]
        public void Length1(MyVector a, double expected)
        {
            Assert.Equal(a.Length(), expected);
        }

        /**
        * CLASS DATA
        */

        [Theory]
        [ClassData(typeof(DataMultiplication))]
        public void MultiplicationVectorTimesVector(MyVector a, MyVector b, double expected)
        {
            Assert.Equal(a * b, expected);
        }

    }

}