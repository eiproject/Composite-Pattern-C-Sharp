using CompositePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern {
  class Simulator {
    private IFactory _factory;
    internal Simulator() {
      _factory = new CounterFactory();
    }
    internal void Simulate() {
      IQuack mallardDuck = _factory.CreateMallardDuck();
      IQuack redheadDuck = _factory.CreateRedheadDuck();
      IQuack duckCall = _factory.CreateDuckCall();
      IQuack rubberDuck = _factory.CreateRubberDuck();
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
