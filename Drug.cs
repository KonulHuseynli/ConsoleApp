using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    class Drug
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public string Name { get; set; }
        public string DrugType { get; set; }
        private int _id;
        public Drug()
        {
            _id++;
            Id = _id;
        }

    }
}
