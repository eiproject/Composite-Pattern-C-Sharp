using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models {
  class Observer : IObserver {
    void IObserver.Update(IQuackObserver animal) {
      Console.WriteLine($"Notification: { animal.GetType().Name } just quacked.");
    }
  }
}
