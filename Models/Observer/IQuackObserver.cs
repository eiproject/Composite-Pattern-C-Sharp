namespace CompoundPattern.Models {
  interface IQuackObserver {
    void RegisterObserver(ISubscriber observer);
    void NotifyObservers();
  }
}
