using CompositePattern.Models; 

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

      Flock flocks = new Flock();
      flocks.AddAnimal(mallardDuck);
      flocks.AddAnimal(redheadDuck);
      flocks.AddAnimal(duckCall);
      flocks.AddAnimal(rubberDuck);
      flocks.AddAnimal(goose);

      IObserver theObserver = new Observer();
      flocks.RegisterObserver(theObserver);
      Simulate(flocks);
      QuackCounter.CheckCounter();
    }
    void Simulate(IQuack duck) {
      duck.Quack();
    }
  }
}
