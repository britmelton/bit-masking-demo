using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bit_masking_demo.Domain
{
    public enum OptionsEnum
    {
        None = 0,
        Ketchup = 1 << 0,
        Mustard = 1 << 1,
        Onion = 1 << 2,
        Pickles = 1 << 3,
        Lettuce = 1 << 4,
        Sauce = 1 << 5,
        Tomato = 1 << 6,
        LeafLettuce = 1 << 7,
        Cheese = 1 << 8,
        Mayo = 1 << 9,
    }
}
