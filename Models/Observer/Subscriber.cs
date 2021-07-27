using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern.Models {
  class Subscriber : ISubscriber {
    void ISubscriber.Update(IQuackObserver animal) {
      Console.WriteLine($"Notification: { animal.GetType().Name } just quacked.");
    }
  }
}
