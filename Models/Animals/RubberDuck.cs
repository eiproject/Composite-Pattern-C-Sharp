using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern.Models {
  class RubberDuck : IQuack {
    IQuackObserver _observer;
    IQuackObserver IQuack.Observer { get { return _observer; } }
    internal RubberDuck() { _observer = new QuackObserver(this); }
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
