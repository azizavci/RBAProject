using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBAProject.Models
{
    public class MultipleModels
    {
        public IEnumerable<SelectListItem> GetBrands { get; set; }
        public IEnumerable<SelectListItem> GetModels { get; set; }

    }
}
