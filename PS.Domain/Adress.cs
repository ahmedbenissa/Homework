using System;
using Microsoft.EntityFrameworkCore;

namespace PS.Domain
{
    [Owned]
    public class Adress
    {
        public String City { get; set; }

        public String StreetAdress { get; set; }

    }
}
