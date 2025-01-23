using static Practical_Three.InterCalculate;

namespace Practical_Three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to Programmm...... ");
            int a = Convert.ToInt16(Console.ReadLine());
            switch (a)
            {
                case 1:
                    DivideBYZero dbz = new DivideBYZero();
                    dbz.DicvideBYZero();
                    break;
                case 2:
                    FiveUSerValue fuv = new FiveUSerValue();
                    fuv.FiveUserValue();
                    break;
                case 3:
                    CalculateOne sa = new CalculateOne();
                    sa.SumOfTwo(3, 4);
                    sa.SumOfThree(6, 4, 3);
                    break;
                case 4:
                    Result c = new Result();
                    c.Addition(10, 20);
                    c.Substraction(10, 20);
                    
                    break;
                case 5:
                    StringMethod sm = new StringMethod();
                    sm.StringFun();
                    break;
                case 6:
                    ConvertedString sc = new ConvertedString();
                    sc.ConStrinf();
                    break;
                case 7:
                    CalculateShape cs = new CalculateShape();
                    cs.Cirle(5);
                    cs.Cirle(5);
                    cs.Traingle(5,3);
                    cs.Square(3);
                    break;
                case 8:
                    EvenNumberChecker ec = new EvenNumberChecker();
                    ec.CheckEvenNumber(6);
                    break;
                case 9:
                    LongestWorld lw = new LongestWorld();
                    lw.lonfff();
                    break;
                case 10:
                    CharcterCheck cc= new CharcterCheck();
                    cc.Check();
                    break;
                default:
                    Console.WriteLine("Invalid Choose:");
                    break;
            }
        }
    }
}
