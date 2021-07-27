namespace CompoundPattern.Models {
  interface IQuack : IQuackObserver {
    void Quack();
    IQuackObserver Observer { get; }
  }
}
