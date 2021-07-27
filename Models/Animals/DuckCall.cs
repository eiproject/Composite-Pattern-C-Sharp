using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern.Models {
  class DuckCall : IQuack {
    IQuackObserver _observer;
    IQuackObserver IQuack.Observer { get { return _observer; } }
    internal DuckCall() {
      _observer = new QuackObserver(this);
    }

    void IQuack.Quack() {
      Console.WriteLine("kwak");
      _observer.NotifyObservers();
    }

    void IQuackObserver.RegisterObserver(IObserver observer) {
      _observer.RegisterObserver(observer);
    }

    void IQuackObserver.NotifyObservers() {
      _observer.NotifyObservers();
    }
  }
}
