using CompositePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern {
  class Simulator {
    internal Simulator() { }
    internal void Simulate() {
      IQuack mallardDuck = new MallardDuck();
      IQuack redheadDuck = new RedheadDuck();
      IQuack duckCall = new DuckCall();
      IQuack rubberDuck = new RubberDuck();
      IQuack goose = new GooseAdapter(new Goose());


      Console.WriteLine("Duck Simulator");
      Simulate(mallardDuck);
      Simulate(redheadDuck);
      Simulate(duckCall);
      Simulate(rubberDuck);
      Simulate(goose);
    }
    void Simulate(IQuack duck) {
      duck.Quack();
    }
  }
}
