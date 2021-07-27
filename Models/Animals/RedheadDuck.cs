using System; 

namespace CompositePattern.Models {
  class RedheadDuck : IQuack {
    IQuackObserver _observer;
    IQuackObserver IQuack.Observer { get { return _observer; } }
    internal RedheadDuck() { 
      _observer = new QuackObserver(this); 
    }
    void IQuack.Quack() {
      Console.WriteLine("Quack");
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
