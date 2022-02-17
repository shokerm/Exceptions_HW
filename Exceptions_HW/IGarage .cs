using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HW
{
    public interface IGarage
    {
        void FixCar(Car c);
        void TakeOutCar(Car c);
        void AddCar(Car c1);

    }
}
