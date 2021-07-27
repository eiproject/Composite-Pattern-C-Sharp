using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models {
  interface IFactory {
    IQuack CreateMallardDuck();
    IQuack CreateRedheadDuck();
    IQuack CreateDuckCall();
    IQuack CreateRubberDuck();
  }
}
