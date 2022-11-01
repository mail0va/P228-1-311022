using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228_1_task_311022.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public int BrandId { get; set; }
        public List<Car> Cars { get; set; }
    }
}
