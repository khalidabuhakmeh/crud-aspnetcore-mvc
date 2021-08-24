using System;
using System.Collections;

namespace Crud.ViewModels.Widgets
{
    public class IndexViewModel
    {
        public IEnumerable Results { get; set; }
            = Array.Empty<object>();
    }
}