using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class testingmethod
    {
       public int addTwoNumber()
        {
            int num1 = 100;
            int num2 = 20;
            int result = 0;
            result = num1 + num2;
            return result;
        }
        public string getName()
        {
            string name = "Myat Ko";
            return name;
        }
        public double calculateCircleArea()
        {
            double pi = 3.14;
            double r = 2;
            double area = pi * r*r;
            return area;
        }
        public void addTwoNumber(int num1 ,int num2)
        {//int num1 =100; int num2 =20;
            int add = (num1 + num2)/2;
            Console.WriteLine("value"+add);
        }
        public double calculateCircleArea(double radius)
        {
            double pi= Math.PI;
            double area = pi * radius*radius;
            return area;
        }
        public string rank(string rank)
        {
            return rank;
        }
        public int rankday(int day)
        {
            return day;
        }
        public double convertLbtoKg(double Lb)
        {
            double kgweight = Lb * 0.45;
            return kgweight;
        }
        public bool evenodd(int num)
        {
            if (num % 2 == 0)
            { return true; }
            else
            {
                return false;
            }

        }
    }
}
