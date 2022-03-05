using System;

namespace PS.Domain
{
    public class Chemical : Product
    {
        public Adress MyAdress { get; set; }
        public String LabName { get; set; }
        public String StreetAddress { get; set; }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine(" City :" + MyAdress.City);
        }
        public override void GetMyType()
        {
            Console.WriteLine("Chemical:/n name" +
                this.Name +
                ",City" + MyAdress.City +
                ",labName:" + MyAdress +
                ",StreetAdress:" + MyAdress.StreetAdress);
        }

    }
}
