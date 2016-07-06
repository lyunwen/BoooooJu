using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineDemo
{
    public interface IPeople
    {
        string Name { get; set; }
        int Age { get; set; }
        decimal Weight { get; set; }
    }
}
