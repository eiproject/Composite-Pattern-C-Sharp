using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models {
  class Factory : IFactory {
    IQuack IFactory.CreateDuckCall() {
      return new DuckCall();
    }

    IQuack IFactory.CreateMallardDuck() {
      return new MallardDuck();
    }

    IQuack IFactory.CreateRedheadDuck() {
      return new RedheadDuck();
    }

    IQuack IFactory.CreateRubberDuck() {
      return new RubberDuck();
    }
  }
}
