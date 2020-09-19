using System;
using System.Collections.Generic;
using System.Text;

namespace TwoColumnListView.Models
{
    public class FruitListGroup:List<FruitContainer>
    {
        public string FirstLetter { get; private set; }

        public FruitListGroup(string firstLetter, List<FruitContainer> container) :base (container)
        {
            FirstLetter = firstLetter;
        }
    }
}
