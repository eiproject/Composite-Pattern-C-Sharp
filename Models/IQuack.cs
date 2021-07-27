namespace CompositePattern.Models {
  interface IQuack : IQuackObserver {
    void Quack();
    IQuackObserver Observer { get; }
  }
}
