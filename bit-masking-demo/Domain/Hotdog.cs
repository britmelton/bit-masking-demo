using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bit_masking_demo.Domain
{
    public class Hotdog
    {

        public Options Options { get; set; } = new Options();

        public void AddKetchup()
        {
            Options.HasKetchup = true;
        }

        public void AddMustard()
        {
            Options.HasMustard = true;
        }

    }
}
