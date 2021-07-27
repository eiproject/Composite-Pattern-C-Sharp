namespace CompoundPattern.Models {
  class GooseAdapter : IQuack {
    IQuackObserver _observer;
    IQuackObserver IQuack.Observer { get { return _observer; } }
    private Goose _goose;
    internal GooseAdapter(Goose goose) {
      _goose = goose;
      _observer = new QuackObserver(this);
    }
    void IQuack.Quack() {
      _goose.honk();
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
