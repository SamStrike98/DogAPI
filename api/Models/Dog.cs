using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Measurement
    {
        public double Male { get; set; }
        public double Female { get; set; }
    }
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Origin { get; set; } = string.Empty;
        public Measurement Height { get; set; } = new Measurement();
        public Measurement Weight { get; set; } = new Measurement();
        public string Nickname { get; set; } = string.Empty;
        public double LifeSpan { get; set; }
        public string Coat { get; set; } = string.Empty;
        public string Colour { get; set; } = string.Empty;
        public string Characteristics { get; set; } = string.Empty;

    }
}