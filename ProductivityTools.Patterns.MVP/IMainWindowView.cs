using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Patterns.MVP
{
    interface IMainWindowView
    {
        event EventHandler Calculate;

        int A { get; set; }
        int B { get; set; }
        int Result { get; set; }
    }
}
