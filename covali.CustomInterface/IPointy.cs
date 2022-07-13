using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covali.CustomInterface
{
    byte Points { get; }
    internal interface IPointy
    {
        byte GetNumberOfPoints();
    }
}
