using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBAProject.DTOs
{
    public class CarDetailDTO
    {
        public string BrandName { get; set; }
        public string ImagePath { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Plate { get; set; }
        public string Status { get; set; }

    }
}
