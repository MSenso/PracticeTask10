using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeTask10;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] lines = File.ReadAllLines("input1.txt");
            double res;
            OneList list = new OneList(lines);
            string show = list.Show();
            if (list.Length > 0)
            {
                res = list.Sum_Calculation(x: 10);
                res = list.Sum_Calculation(x: 3);
                res = list.Sum_Calculation(x: 0);
            }

            lines = File.ReadAllLines("input2.txt");
            list = new OneList(lines);
            show = list.Show();
            if (list.Length > 0)
            {
                res = list.Sum_Calculation(x: 10);
                res = list.Sum_Calculation(x: 3);
                res = list.Sum_Calculation(x: 0);
            }

            lines = File.ReadAllLines("input3.txt");
            list = new OneList(lines);
            show = list.Show();
            if (list.Length > 0)
            {
                res = list.Sum_Calculation(x: 10);
                res = list.Sum_Calculation(x: 3);
                res = list.Sum_Calculation(x: 0);
            }

            lines = File.ReadAllLines("input4.txt");
            list = new OneList(lines);
            show = list.Show();
            if (list.Length > 0)
            {
                res = list.Sum_Calculation(x: 10);
                res = list.Sum_Calculation(x: 3);
                res = list.Sum_Calculation(x: 0);
            }

            lines = File.ReadAllLines("input5.txt");
            list = new OneList(lines);
            show = list.Show();
            if (list.Length > 0)
            {
                res = list.Sum_Calculation(x: 10);
                res = list.Sum_Calculation(x: 3);
                res = list.Sum_Calculation(x: 0);
            }
        }
    }
}
