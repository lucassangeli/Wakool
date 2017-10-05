using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    [AttributeUsage(AttributeTargets.Class)]
    public class Title : Attribute
    {
        public string text { get; set; }
        public Title(string titulo)
        {
            text = titulo;
        }
    }
}