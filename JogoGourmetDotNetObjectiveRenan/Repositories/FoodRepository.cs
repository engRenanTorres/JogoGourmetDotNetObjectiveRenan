using JogoGourmetDotNetObjectiveRenan.Model;
using JogoGourmetDotNetObjectiveRenan.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNetObjectiveRenan.Repository
{
    public class FoodRepository : IGuessRepository
    {

        public List<FoodGuess> FoodGuesses { get; set; }
        public List<Tip> Tips { get; set; }
        public FoodRepository()
        {
            var jsonData = FakeData.jsonFoodData;
            var data = JsonConvert.DeserializeObject<FoodGuessData>(jsonData);
            FoodGuesses = data.FoodGuess;
            Tips = data.Tip;
        }
        public FoodGuess Get(int id)
        {
            return FoodGuesses.Find(f => f.Id == id);
        }

        public IEnumerable<FoodGuess> GetAll()
        {
            return FoodGuesses;
        }

        public FoodGuess GetBySimilarityTips(IEnumerable<Tip> gameTips)
        {
            return FoodGuesses.Last();
        }
    }
}
