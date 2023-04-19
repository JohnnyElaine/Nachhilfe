using Overview;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyVector
{
    public class DataMultiplication : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {new MyVector(1,2,3), new MyVector(0,0,0), 0};
            yield return new object[] { new MyVector(1, 2, 3), new MyVector(1, 1, 1), 6 };
            yield return new object[] { new MyVector(1, 2, 3), new MyVector(-1, 10, -10), -11};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
