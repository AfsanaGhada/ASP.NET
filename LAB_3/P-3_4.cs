using System;
namespace Lab_3
{
    public interface Calculate
    {
        int Addition(int a, int b);
        int Subtraction(int a, int b);
    }

    public class Result1 : Calculate
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}

        