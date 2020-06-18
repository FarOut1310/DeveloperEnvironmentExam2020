using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperEnvironmentExam2020.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
