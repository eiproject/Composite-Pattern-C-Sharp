using CompositePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Business {
  class GooseAdapter {
    private Goose _goose;
    internal GooseAdapter(Goose goose) {
      _goose = goose;
    }
  }
}
