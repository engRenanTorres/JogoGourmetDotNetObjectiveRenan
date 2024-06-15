using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNetObjectiveRenan.Model
{
    public interface IFoodRepository
    {
        FoodGuess Get(int id);
        FoodGuess GetBySimilarityTips(IEnumerable<int> gameTips);
        IEnumerable<FoodGuess> GetAll();
    }
}
