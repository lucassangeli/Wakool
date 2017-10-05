using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnotation.Atributi
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomVisibleAttribute : Attribute
    {
        public bool visivel { get; set; }
        public CustomVisibleAttribute(bool visibel = true)
        {
            visivel = visibel;
        }
    }
}
