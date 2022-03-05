using System;

namespace PS.Domain
{
    public class Biological : Product
    {
        public String Herbs { get; set; }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Herbs:" + Herbs);
        }
        public override void GetMyType()
        {
            Console.WriteLine("Biological");
        }
    }
}
