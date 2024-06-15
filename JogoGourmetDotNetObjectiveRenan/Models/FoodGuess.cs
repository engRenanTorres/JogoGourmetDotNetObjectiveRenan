using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNetObjectiveRenan.Model
{
    public class FoodGuess
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<int> Tips { get; set; } = new List<int>();
    }
}
