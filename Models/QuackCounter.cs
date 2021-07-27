using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models {
  class QuackCounter : IQuack {
    private IQuack _animal;
    private static int _numberOfQuack;

    internal QuackCounter(IQuack animal) {
      _animal = animal;
    }

    void IQuack.Quack() {
      _animal.Quack();
      _numberOfQuack++;
    }

    internal static void CheckCounter() {
      Console.WriteLine($"Number of Quack : { _numberOfQuack }");
    }
  }
}
