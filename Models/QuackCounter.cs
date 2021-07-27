using System; 

namespace CompoundPattern.Models {
  class QuackCounter : IQuack {
    private IQuack _animal;
    IQuackObserver _observer;
    IQuackObserver IQuack.Observer { get { return _observer; } }
    private static int _numberOfQuack;

    internal QuackCounter(IQuack animal) {
      _animal = animal;
      _observer = animal.Observer;
    }

    void IQuack.Quack() {
      _animal.Quack();
      _numberOfQuack++;
    }

    internal static void CheckCounter() {
      Console.WriteLine($"Number of Quack : { _numberOfQuack }");
    }

    void IQuackObserver.RegisterObserver(ISubscriber observer) {
      _observer.RegisterObserver(observer);
    }

    void IQuackObserver.NotifyObservers() {
      _observer.NotifyObservers();
    }
  }
}
