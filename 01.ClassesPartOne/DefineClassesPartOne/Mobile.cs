using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClassesPartOne
{
    class Mobile
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private List<Call> callHistory;

        private static Mobile iPhone4s = new Mobile(
            "iPhone 4S",
            "Apple",
            500,
            "Rene",
            new Battery("Samsung",48, 24),
            new Display(4.5, 16000000));
       

        public Mobile()
        {

        }
        public Mobile(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;

        }
        public Mobile(string model, string manufacture,decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;

        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public static Mobile IPhone4S
        {
            get
            {
                return iPhone4s;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
           private set
            {
                this.callHistory = value;
            }
        }


        public object Display { get; private set; }
        public object Battery { get; private set; }

        public void AddCall(Call call)
        {
            this.CallHistory = null;
            this.CallHistory.Add(call);
        }

        public override string ToString()
        {
            return $"Model: {this.Model}\nManufacturer: {this.Manufacturer}\nPrice: {this.Price}\nOwner: {this.Owner}\nDisplay: {this.Display}\nBattery: {this.Battery}";
        }

    }
}
