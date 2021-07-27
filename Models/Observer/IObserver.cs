using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern.Models {
  interface IObserver {
    void Update(IQuackObserver animal);
  }
}
