using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClassesPartOne
{
    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(string model, int hoursIdle,
           int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            
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

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
        public override string ToString()
        {
            return $"Model - {this.Model}; Hours idle - {this.HoursIdle};Hours talk - {this.HoursTalk}";
        }
    }
}
