using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models {
  class GooseAdapter : IQuack {
    private Goose _goose;
    internal GooseAdapter(Goose goose) {
      _goose = goose;
    }
    void IQuack.Quack() {
      _goose.honk();
    }
  }
}
