using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models {
  class RubberDuck : IQuack {
    internal RubberDuck() { }
    void IQuack.Quack() {
      Console.WriteLine("Squeak");
    }
  }
}
