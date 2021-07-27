namespace CompoundPattern.Models {
  interface IQuackObserver {
    void RegisterObserver(IObserver observer);
    void NotifyObservers();
  }
}
