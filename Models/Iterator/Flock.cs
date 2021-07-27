using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models {
  class Flock : IQuack {
    ArrayList _flockOfAnimals;
    internal Flock() {
      _flockOfAnimals = new ArrayList();
    }
    internal void AddAnimal(IQuack animal) {
      _flockOfAnimals.Add(animal);
    }
    void IQuack.Quack() {
      foreach (IQuack animal in  _flockOfAnimals) {
        animal.Quack();
      }
    }
  }
}
