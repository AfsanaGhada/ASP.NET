namespace LAB_4
{
   public class RBI
{
    public virtual void CalculateInterest()
        {
            Console.WriteLine("Interest rate by RBI: 4%");
        }
    }

    class HDFC : RBI
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Interest rate by HDFC: 6%");
        }
    }

    class SBI : RBI
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Interest rate by SBI: 5%");
        }
    }

    class ICICI : RBI
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Interest rate by ICICI: 6.5%");
        }
    }

}
