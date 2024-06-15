using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNetObjectiveRenan.Model
{
    public interface IGuessRepository
    {
        FoodGuess Get(int id);
        FoodGuess GetBySimilarityTips(IEnumerable<Tip> gameTips);
        IEnumerable<FoodGuess> GetAll();
    }
}
