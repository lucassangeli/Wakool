using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TitleProperty : Attribute
    {
        public string Texto { get; set; }

        public TitleProperty(string text)
        {
            Texto = text.Trim();
        }
    }
}
