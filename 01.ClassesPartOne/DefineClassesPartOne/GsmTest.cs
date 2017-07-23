using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClassesPartOne
{
   public class GsmTest
    {
        
        private Mobile[] gsmsColection =
                 {
                new Mobile("Iphone 6S", "Apple", 800, "Rene", new Battery("Samsung", 72, 48), new Display(5.5, 16000000)),
                new Mobile("Galaxy S7", "Samsung", 700, "Rosi", new Battery("Samsung", 48, 24), new Display(5.7, 16000000)),
                new Mobile("Galaxy Note 5", "Samsung", 650, "Koko", new Battery("Samsung", 60, 36), new Display(5.9, 15000000))
            };
        
   
        
    }
}
