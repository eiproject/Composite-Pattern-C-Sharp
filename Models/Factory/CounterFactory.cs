using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models {
  class CounterFactory : IFactory {
    IQuack IFactory.CreateDuckCall() {
      return new QuackCounter(new DuckCall());
    }

    IQuack IFactory.CreateMallardDuck() {
      return new QuackCounter(new MallardDuck());
    }

    IQuack IFactory.CreateRedheadDuck() {
      return new QuackCounter(new RedheadDuck());
    }

    IQuack IFactory.CreateRubberDuck() {
      return new QuackCounter(new RubberDuck());
    }
  }
}
