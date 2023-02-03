using Приложуха;
using System;

namespace TestProject
{
    public class Test1
    {
        LeeAlgorithm tras;

        [SetUp]
        public void Setup()
        {
            int[,] a = new int[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (i == 0 || j == 0 || i == 12 - 1 || j == 12 - 1)
                    {
                        a[i, j] = -4;
                    }
                    else
                    {
                        a[i, j] = -1;
                    }
                }
            }
            a[1, 1] = 0;
            a[10, 10] = -2;
            tras = new LeeAlgorithm(a);
        }

        [Test]
        public void TestVseHorosho()
        {
            var actual = tras.PathFound;
            Assert.AreEqual(true, actual);
        }
    }
        public class Test2
        {
        LeeAlgorithm tras;

        [SetUp]
        public void Setup()
        {
            int[,] a = new int[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (i == 0 || j == 0 || i == 12 - 1 || j == 12 - 1)
                    {
                        a[i,j] = -4;
                    }
                    else
                    {
                        a[i,j] = -1;
                    }
                }
            }
            tras = new LeeAlgorithm(a);
        }

        [Test]
        public void TestNevvedenoNachZnach()
        {
            var actual = tras.PathFound;
            Assert.AreEqual(false, actual);
        }
    }
}