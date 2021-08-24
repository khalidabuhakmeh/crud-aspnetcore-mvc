using System;
using System.Collections;
using System.Collections.Generic;

namespace Crud.ViewModels.Widgets
{
    public class IndexViewModel
    {
        public IEnumerable<WidgetModel> Results { get; set; }
            = Array.Empty<WidgetModel>();
    }

    public class WidgetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Weight { get; set; }
    }
}