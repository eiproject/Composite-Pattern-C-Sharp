using System.Collections;

namespace CompoundPattern.Models {
  class Flock : IQuack {
    ArrayList _flockOfAnimals;
    IQuackObserver _observer;
    IQuackObserver IQuack.Observer { get { return _observer; } }
    internal Flock() {
      _flockOfAnimals = new ArrayList();
      _observer = new QuackObserver(this);
    }
    internal void AddAnimal(IQuack animal) {
      _flockOfAnimals.Add(animal);
    }
    public void NotifyObservers() {
      _observer.NotifyObservers();
    }
    public void Quack() {
      foreach (IQuack animal in  _flockOfAnimals) {
        animal.Quack();
      }
    }
    public void RegisterObserver(ISubscriber observer) {
      foreach (IQuack animal in _flockOfAnimals) {
        animal.RegisterObserver(observer);
      }
    }
  }
}
