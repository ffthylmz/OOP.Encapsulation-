using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A140622_22_.Classes
{
    public class Computer
    {
        public Computer()
        {


        }
        public Computer(int id, string brand, double cpuClockRate)
        {
            this.ID = id;
            this.Brand = brand;
            this.CPUClockRate = cpuClockRate;
        }
        ~Computer() //Tilda İşaretiyle yazılır. (~)
        {


        }
        private int price;
        private string configurationSettings;

        public int PriceForCustomer
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    price = 0;
                }
                else if (value > 25000)
                {
                    price = 2000;
                }
                else
                {
                    price = value;
                }
            }
        }

        public string ConfigurationSettingsForCustomer
        {
            get
            {

                return "Settings: " + configurationSettings;
            }
            set
            {
                if (value.Trim() == "")
                {
                    configurationSettings = "Default Cofiguration";
                }
                else
                {
                    configurationSettings = value;
                }

            }
        }



        private int ID { get; set; }

        private string Brand { get; set; }

        private double CPUClockRate { get; set; }

        public void Boot()
        {



        }
        public void ShutDown()
        {



        }







    }


}
