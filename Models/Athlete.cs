using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Test.api.Models
{
    public class Athlete
    {
        public string Name {get; set;}
        public string Country {get; set;}
        public DateTime Time {get; set;}
    }
}