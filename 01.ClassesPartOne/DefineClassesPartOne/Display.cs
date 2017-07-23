using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClassesPartOne
{
   public class Display
    {
        private double size;
        private int numberColors;
        public Display(double size, int numberColors)
        {
            this.Size = size;
            this.NumberColors = numberColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int NumberColors
        {
            get
            {
                return this.numberColors;
            }
            set
            {
                this.numberColors = value;
            }
        }
    }
}
