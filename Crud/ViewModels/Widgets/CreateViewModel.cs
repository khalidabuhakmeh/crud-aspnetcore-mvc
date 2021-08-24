using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crud.ViewModels.Widgets
{
    public class CreateViewModel
    {
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public string Manufacturer { get; set; }

        public IList<SelectListItem> Manufacturers =
            new List<SelectListItem>
            {
                new("One", "One"),
                new("Two", "Two"),
                new("Three", "Three"),
            };
    }
}