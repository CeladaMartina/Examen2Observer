using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropiedadesBE;

namespace Controller
{
    public interface IObserver
    {
        // Receive update from subject
        float Update(Vuelo vuelo);

        float Update(Hotel hotel);

    }
}
