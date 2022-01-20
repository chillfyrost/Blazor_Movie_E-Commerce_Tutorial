using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorApp.Controls
{
    public partial class Component2
    {
        [CascadingParameter(Name = "ComponentCounter")]
        public int CounterValue { get; set; }
    }
}
