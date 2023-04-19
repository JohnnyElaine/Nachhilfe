using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    public class MyVector
    {
        private double _x, _y, _z;

        public MyVector(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public double DistanceTo(MyVector other)
        {
            double xDiff = Math.Abs(_x - other._x);
            double yDiff = Math.Abs(_y - other._y);
            double zDiff = Math.Abs(_z - other._z);

            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
        }

        public double Length()
        {
            return Math.Sqrt(_x * _x + _y * _y + _z * _z);
        }

        public override string ToString()
        {
            return $"({_x}, {_y}, {_z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()) ) return false;
 
            MyVector other = (MyVector)obj;

            return _x == other._x && _y == other._y && _z == other._z;
        }

        public static MyVector operator +(MyVector a, MyVector b)
        {
            return new MyVector(a._x + b._x, a._y + b._y, a._z + b._z);
        }

        public static MyVector operator -(MyVector a, MyVector b)
        {
            return new MyVector(a._x - b._x, a._y - b._y, a._z - b._z);
        }

        public static double operator *(MyVector a, MyVector b)
        {
            return a._x * b._x + a._y * b._y + a._z * b._z;
        }

        public static MyVector operator *(MyVector v, double scalar)
        {
            return new MyVector(v._x * scalar, v._y * scalar, v._z * scalar);
        }

        public static MyVector operator *(double scalar, MyVector v)
        {
            return v * scalar;
        }

        public static MyVector operator /(MyVector v, double scalar)
        {
            return new MyVector(v._x / scalar, v._y / scalar, v._z / scalar);
        }

        /*
         * Getter & Setter nur verwenden wenn notwendig
         * 
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }
        */
    }
}
