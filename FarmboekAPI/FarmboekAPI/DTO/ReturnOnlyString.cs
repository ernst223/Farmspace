using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class ReturnOnlyString
    {
        public ReturnOnlyString(string message, int amount)
        {
            myString = message;
            amountOfUploads = amount;
        }
        public string myString { get; set; }
        public int amountOfUploads { get; set; }
    }
}
