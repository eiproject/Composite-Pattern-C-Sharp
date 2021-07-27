namespace CompositePattern.Models {
  interface IQuackObserver {
    void RegisterObserver(IObserver observer);
    void NotifyObservers();
  }
}
