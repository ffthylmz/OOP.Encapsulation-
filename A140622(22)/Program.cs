using A140622_22_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A140622_22_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computerA = new Computer(11941, "Lenovo", 3.25);
            computerA.PriceForCustomer = 25042;
            computerA.ConfigurationSettingsForCustomer = "cmd_adegsdf";

            Computer computerB = new Computer(12041, "HP", 2.95);
            computerB.ConfigurationSettingsForCustomer = "";
            computerB.PriceForCustomer = 25015;

            Computer computerC = new Computer(1542, "Dell", 2.50);
            computerC.ConfigurationSettingsForCustomer = "";
            computerC.PriceForCustomer = 450;


        }
    }
}
