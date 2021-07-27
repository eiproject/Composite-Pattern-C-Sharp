using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern {
  class Program {
    static void Main(string[] args) {
      Simulator duckSimulator = new Simulator();
      duckSimulator.Simulate();
      Console.ReadKey();
    }
  }
}
