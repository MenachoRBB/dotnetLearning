using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public abstract class DocumentoContable
    {
        protected string _siglas;
        public DateTime date { get; set; }  
        public int number { get; set; } 
        public double amount { get; set; }  
        public string siglas { get { return _siglas; } }

        public abstract double Total();
    }
}
