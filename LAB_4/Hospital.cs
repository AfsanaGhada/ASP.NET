namespace LAB_4
{
    public class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("General Hospital Details");
        }
    }

    public class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Hospital: Known for heart surgeries");
        }
    }

    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt Hospital: Specialized in neurology");
        }
    }

    class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul Superspeciality: Best for orthopedics");
        }
    }
}
