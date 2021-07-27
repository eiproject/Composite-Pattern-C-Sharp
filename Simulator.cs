using CompositePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern {
  class Simulator {
    internal Simulator() {
    }
    internal void Simulate() {
      IQuack mallardDuck = new QuackCounter(new MallardDuck());
      IQuack redheadDuck = new QuackCounter(new RedheadDuck());
      IQuack duckCall = new QuackCounter(new DuckCall());
      IQuack rubberDuck = new QuackCounter(new RubberDuck());
      IQuack goose = new GooseAdapter(new Goose());


      Console.WriteLine("Duck Simulator");
      Simulate(mallardDuck);
      Simulate(redheadDuck);
      Simulate(duckCall);
      Simulate(rubberDuck);
      Simulate(goose);

      QuackCounter.CheckCounter();
    }
    void Simulate(IQuack duck) {
      duck.Quack();
    }
  }
}
