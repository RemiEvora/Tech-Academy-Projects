using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg162
{
    public class Cadet
    {
        //3.Chain two constructors together.

        public Cadet(string name) : this(name, "red")
        {

        }

        public Cadet (string name, string shirtColor)
        {
            Name = name;
            Shirt = shirtColor;
        }

        public string Name { get; set; }
        public string Shirt { get; set; }
    }
}
