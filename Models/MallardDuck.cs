using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models {
  class MallardDuck : IQuack {
    internal MallardDuck() { }
    void IQuack.Quack() {
      Console.WriteLine("Quack");
    }
  }
}
