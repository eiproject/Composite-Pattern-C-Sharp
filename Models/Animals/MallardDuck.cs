using System;

namespace CompoundPattern.Models {
  class MallardDuck : IQuack {
    IQuackObserver _observer;
    IQuackObserver IQuack.Observer { get { return _observer; } }
    internal MallardDuck() { 
      _observer = new QuackObserver(this); 
    }
    void IQuack.Quack() {
      Console.WriteLine("Quack");
      _observer.NotifyObservers();
    }

    void IQuackObserver.RegisterObserver(ISubscriber observer) {
      _observer.RegisterObserver(observer);
    }

    void IQuackObserver.NotifyObservers() {
      _observer.NotifyObservers();
    }
  }
}
